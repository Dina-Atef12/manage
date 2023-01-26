namespace manage
{
    internal class SqlCommand
    {
        public SqlConnection Connection { get; internal set; }
        public string CommandText { get; internal set; }

        internal int ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }
    }
}