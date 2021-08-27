using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pedly.Models
{
    public class User
    {   
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string eMail { get; set; }
        public string password { get; set; }
    }
}
