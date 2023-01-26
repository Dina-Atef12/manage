using System.Data;

namespace manage
{
    internal class SqlConnection
    {
        private string conStr;

        public SqlConnection(string conStr)
        {
            this.conStr = conStr;
        }

        public ConnectionState State { get; internal set; }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}