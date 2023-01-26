using System.Data;

namespace manage
{
    internal class SqlDataAdapter
    {
        private string query;
        private object constr;

        public SqlDataAdapter(string query, object constr)
        {
            this.query = query;
            this.constr = constr;
        }

        internal void Fill(DataTable dt)
        {
            throw new NotImplementedException();
        }
    }
}