using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace NovaDataManagement
{
	public partial class frmDatabaseList : Form
	{
		private InfoLogin infoLogin;
		private List<Script> frm_listScript;
		private List<Result> frm_resultList;
		private string frm_pathBak;
		private string frm_pathFolder;
		private frmActionState frm_actionSate;
		//Server=myServerName\myInstanceName;Database=myDataBase;
		private static string[] attConnect = { "Server=", ";Database=", ";User ID=", ";Password="};
		public frmDatabaseList(InfoLogin info)
		{
			InitializeComponent();
			infoLogin = new InfoLogin(info.Machine, info.SeverName, info.User, info.Password);
			frm_GetListDB();
		}

		#region "Event"
		private void frmDatabaseList_Load(object sender, EventArgs e)
		{
			//Make defaultFolder for backup
			frm_listScript = new List<Script>();
			frm_pathBak = Properties.Settings.Default.default_backup_directory;
			frm_pathFolder = Properties.Settings.Default.default_script_directory;
			if (!Directory.Exists(frm_pathBak))
			{
				Directory.CreateDirectory(frm_pathBak);
			}
			lbFolderBackup.Text = "Folder Backup: " + frm_pathBak;
			lbFolderPath.Text = "Folder Path: " + frm_pathFolder;
		}

		private void btnUpgrade_Click(object sender, EventArgs e)
		{
			frm_Upgrade();
		}

		private void toolRefresh_Click(object sender, EventArgs e)
		{
			frm_GetListDB();
		}
		//Add/Clear Script
		#region "Handle Script"
		private void btnClearListScript_Click(object sender, EventArgs e)
		{
			frm_listScript = new List<Script>();
			lbFolderPath.Text = "Folder Path:";
		}
		private void btnAddFolder_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
			folderBrowser.SelectedPath = frm_pathFolder;
			folderBrowser.ShowNewFolderButton = false;
			try
			{
				if (folderBrowser.ShowDialog() == DialogResult.OK)
				{
					frm_pathFolder = folderBrowser.SelectedPath;
					Properties.Settings.Default.default_script_directory = frm_pathFolder;
					Properties.Settings.Default.Save();
					lbFolderPath.Text = "Folder Path: " + frm_pathFolder;
					AddFolder(frm_pathFolder);
				}
			}
			catch (Exception ex) { throw ex; }
		}
		private void btnGetFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFile = new OpenFileDialog();
			openFile.InitialDirectory = frm_pathFolder;
			openFile.Title = "Select the script file";
			openFile.Filter = "Select Valid Document(*.sql)|*.sql";
			openFile.FilterIndex = 1;
			openFile.Multiselect = true;
			try
			{
				if (openFile.ShowDialog() == DialogResult.OK)
				{
					if (openFile.CheckFileExists)
					{
						string[] filesName = openFile.FileNames;
						frm_pathFolder = Path.GetDirectoryName(filesName[0]);
						Properties.Settings.Default.default_backup_directory = frm_pathFolder;
						Properties.Settings.Default.Save();
						GetScript(filesName);
						lbFolderPath.Text = "Folder Path: " + Path.GetDirectoryName(filesName[0]);
					}
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		private void btnBackUp_Click(object sender, EventArgs e)
		{
			frm_resultList = new List<Result>();
			try
			{
				IEnumerable<InfoDB> listBak = ListUseDB();
				foreach (InfoDB db in listBak)
				{
					string connectString = attConnect[0] + db.DataSource +
											attConnect[2] + db.User +
											attConnect[3] + db.Password;
					using (SqlConnection connection = new SqlConnection(connectString))
					{
						connection.Open();
						string result = BackUp(connection, db.Catalog);
						frm_resultList.Add(new Result(result, db));
					}
					ShowFrmActionState(frm_resultList);
				}
			}
			catch (Exception ex) { throw ex; }
		}
		#endregion

		//Right Click event in Form
		#region "Right click"
		private void upgradeDBToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_Upgrade();
		}

		private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				frm_GetListDB();
			}
			catch (Exception ex) { throw ex; }
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
		#endregion

		#endregion


		#region "Function"
		// Handle Script
		private string MakeScript(string[] filesName)
		{
			StringBuilder builder = new StringBuilder();
			foreach (string file in filesName)
			{
				string script = File.ReadAllText(file);
				builder.AppendLine(script);
			}
			return builder.ToString();
		}
		//Filter sql file
		private string[] FileFilter(string path)
		{
			var needFiles = from file in Directory.EnumerateFiles(path)
							let extension = Path.GetExtension(file)
							where extension.Equals(".sql")
							select file;
			return needFiles as string[];
		}
		//Add folder have 3 levels at max and it mean add a version folder
		//Important: Each folder contain only folders or script files and not empty        
		private void AddFolder(string pathVersion)
		{
			//Level 1: Get all folder containing script in folder Version
			string[] pathFolders = Directory.GetDirectories(pathVersion);
			string[] filesScript = Directory.GetFiles(pathVersion);

			if (pathFolders.Length > 0)
			{
				//If it is folder contain 
				foreach (string path in pathFolders)
				{
					string[] files = Directory.GetFiles(path);
					if (files.Length > 0)
					{
						GetScript(files);
					}
					else
					{
						string[] childFolders = Directory.GetDirectories(path);
						foreach (string folder in childFolders)
						{
							string[] filesFolder = Directory.GetFiles(folder);
							if (filesFolder.Length > 0)
							{
								GetScript(filesFolder);
							}
						}
					}
				}
			}
			else if (filesScript.Length > 0)
			{
				GetScript(filesScript);
			}
			else
			{
				MessageBox.Show("Folder is empty");
			}
		}
		private void GetScript(string[] files)
		{
			Script script = new Script();
			script.Query = MakeScript(files);
			string scriptName = Path.GetDirectoryName(files[0]);
			script.Folder = new DirectoryInfo(scriptName).Name;
			frm_listScript.Add(script);
		}
		//Get List DBInfo
		private List<InfoDB> GetDBs(InfoLogin infoLogin)
		{
			List<InfoDB> list = new List<InfoDB>();
			var monitoring_db = Properties.Settings.Default.default_monitoring_dbname;
			string connectString = attConnect[0] + infoLogin.Machine +
									attConnect[2] + infoLogin.User +
									attConnect[3] + infoLogin.Password;
			using (SqlConnection con = new SqlConnection(connectString))
			{
				con.Open();
				string query = String.Format(
					@"SELECT s.datasource, ds.[catalog] , d.createdDate, d.brandname, d.domainname, s.[user],s.password
						FROM	[{0}].[dbo].[storage] as s,
								[{0}].[dbo].[domain_storage] as ds,                            
								[{0}].[dbo].[domain] as d
						WHERE S.ID = DS.storageid AND d.ID = ds.domainid AND s.[user] = '{1}'; ", monitoring_db, infoLogin.User);
				using (SqlCommand cmd = new SqlCommand(query, con))
				{
					using (SqlDataReader dbList = cmd.ExecuteReader())
					{
						while (dbList.Read())
						{
							InfoDB dB = new InfoDB();
							dB.DataSource = dbList["datasource"].ToString();
							dB.Catalog = dbList["catalog"].ToString();
							dB.CreatedDate = dbList["createdDate"].ToString();
							dB.BrandName = dbList["brandName"].ToString();
							dB.DomainName = dbList["domainName"].ToString();
							dB.User = dbList["user"].ToString();
							dB.Password = dbList["password"].ToString();
							dB.UpdateChoice = false;
							list.Add(dB);
						}
					}
				}
			}
			return list;
		}
		private void frm_GetListDB()
		{
			gvDBList.DataSource = GetDBs(infoLogin);
		}
		//Upgrade
		private void UpgradeDB(InfoDB db)
		{
			string connectString = attConnect[0] + db.DataSource +
									attConnect[1] + db.Catalog +
									attConnect[2] + db.User +
									attConnect[3] + db.Password;

			using (SqlConnection connection = new SqlConnection(connectString))
			{
				//Back up
				connection.Open();
				string resultBackUp = BackUp(connection, db.Catalog);
				//Back up if success backup
				if (resultBackUp == null)
				{
					ServerConnection svrConnection = new ServerConnection(connection);
					Server server = new Server(svrConnection);
					////To Avoid TimeOut Exception
					server.ConnectionContext.StatementTimeout = 60 * 60;
					server.ConnectionContext.BeginTransaction();
					bool stateUpgrade = true;
					foreach (Script item in frm_listScript)
					{
						try
						{
							server.ConnectionContext.ExecuteNonQuery(item.Query);
						}
						catch (ExecutionFailureException ex)
						{
							Script stateScript;
							stateScript = item;
							stateScript.ResultUpgrade = ex.GetBaseException().Message;
							frm_resultList.Add(new Result(resultBackUp, stateScript, db));
							server.ConnectionContext.RollBackTransaction();
							stateUpgrade = false;
							break;
						}
					}
					if (stateUpgrade)
					{
						server.ConnectionContext.CommitTransaction();
						frm_resultList.Add(new Result(db));
					}
				}
				else
				{
					frm_resultList.Add(new Result(resultBackUp, db));
				}
				frm_actionSate.StateList.DataSource = frm_resultList;
			}
		}
		private void frm_Upgrade()
		{
			IEnumerable<InfoDB> listUpgrade = ListUseDB();
			frm_resultList = new List<Result>();			
			if (frm_listScript.Count > 0)
			{				
				foreach (InfoDB item in listUpgrade)
				{
					var db = item;
					Thread worker = new Thread(()=>UpgradeDB(db));
					worker.Start();
					//UpgradeDB(item);
				}
				ShowFrmActionState(frm_resultList);
				return;
			}
			MessageBox.Show("Do not have Script");
		}
		private string BackUp(SqlConnection connection, string dbName)
		{
			string time = DateTime.Now.ToString("_ddmmyyyy_hhmm");
			string filePath = frm_pathBak + @"\" + dbName + time + ".bak";
			string testQuery = "BACKUP DATABASE " + dbName + " TO DISK = '" + filePath + "'";
			using (SqlCommand command = new SqlCommand(testQuery, connection))
			{
				command.CommandTimeout = 60 * 60;
				try
				{
					command.ExecuteNonQuery();
				}
				catch (SqlException ex)
				{
					return ex.Message;
				}
			}
			return null;
		}
		private IEnumerable<InfoDB> ListUseDB()
		{
			List<InfoDB> listUseDB = gvDBList.DataSource as List<InfoDB>;
			var listUse = listUseDB.Where(sDB => sDB.UpdateChoice == true);
			return listUse;
		}
		private void ShowFrmActionState(List<Result> resultAction)
		{
			frm_actionSate = new frmActionState(resultAction);
			frm_actionSate.Show();
		}
		#endregion
	}
}
