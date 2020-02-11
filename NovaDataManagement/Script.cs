namespace NovaDataManagement
{
    public class Script
    {
        private string updateState = null;
        public string Folder { get; set; }
        public string Query { get; set; }
        public string ResultUpgrade
        {
            get 
            {
                if (updateState == null)
                {
                   return "";
                }
                else if (updateState.Equals(""))
                {
                    return "Upgrade Success";
                }
                return updateState; 
            }
            set { updateState = value; }
        }
        public Script()
        {

        }
        public Script(string folder, string query)
        {
            Folder = folder;
            Query = query;
        }
    }
}
