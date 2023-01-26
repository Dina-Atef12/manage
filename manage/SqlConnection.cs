namespace manage
{
    internal class SqlConnection
    {
        private string conStr;

        public SqlConnection(string conStr)
        {
            this.conStr = conStr;
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}