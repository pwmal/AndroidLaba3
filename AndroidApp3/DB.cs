using SQLite;

namespace AndroidApp3
{
    public class DB
    {

        private readonly SQLiteConnection conn;

        public DB(string path)
        {
            conn = new SQLiteConnection(path);
            conn.CreateTable<groupmates>();
        }

        public List<groupmates> GetAll()
        {
            return conn.Table<groupmates>().ToList();
        }

        public int Save(groupmates item)
        {
            return conn.Insert(item);
        }

        public int Delete(groupmates item) 
        {
            return conn.Delete(item);
        }

        public int Update(groupmates item)
        {
            return conn.Update(item);
        }
    }
}
