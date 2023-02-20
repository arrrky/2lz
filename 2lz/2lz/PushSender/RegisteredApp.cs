using SQLite;

namespace _2lz.PushSender
{
    [Table("app")]
    public class RegisteredApp
    {
        [PrimaryKey, Unique, Column("_name")]
        public string Name { get; set; }

        [Unique, Column("_id")]
        public string Id { get; set; }
    }
}