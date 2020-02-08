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
                    return updateState;
                }
                else if (updateState.Equals(""))
                {
                    return "Upgrade Success";
                }
                return this.updateState; 
            }
            set { this.updateState = value; }
        }
        public Script()
        {

        }
        public Script(string folder, string query)
        {
            this.Folder = folder;
            this.Query = query;
        }
    }
}
