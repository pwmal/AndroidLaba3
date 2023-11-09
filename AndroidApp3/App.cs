namespace AndroidApp3
{
    public class App : Application
    {
        private static DB db;

        public static DB Db
        {
            get 
            { 
                if(db == null)
                {
                    db = new DB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "groupmates.db"));
                }
                return db;
            }
        }
    }
}
