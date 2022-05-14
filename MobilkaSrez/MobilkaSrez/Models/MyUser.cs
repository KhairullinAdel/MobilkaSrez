using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MobilkaSrez.Models
{
    public class MyUser
    {
        [PrimaryKey, Column("_id"), AutoIncrement]
        public int id { get; set; }
        [Unique]
        public string Uname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
