using System;
using System.Collections.Generic;
using System.Text;

using SQLite;

namespace MobilkaSrez.Models
{
    public class MyItem
    {
        [PrimaryKey, Column("_id"), AutoIncrement]
        public int id { get; set; }
        [Unique]
        public string Name { get; set; }
        public string SomeAnotherThing { get; set; }
    }
}
