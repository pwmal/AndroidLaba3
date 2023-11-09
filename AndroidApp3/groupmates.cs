using SQLite;

namespace AndroidApp3
{
    public class groupmates
    {
        [PrimaryKey]
        public int id { get; set; }

        public string name { get; set; }

        public string time { get; set; }

    }
}
