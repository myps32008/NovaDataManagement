namespace NovaDataManagement
{
    class Script
    {
        private string updateState = null;
        public string Folder { get; set; }
        public string Query { get; set; }
        public string ErrorAtDB { get; set; }
        public string ResultUpgrade
        {
            get 
            {
                if (updateState == null)
                {
                    return "Upgrade Success";
                }
                return this.ErrorAtDB + " error at " + this.Folder + ": " + this.updateState; 
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
