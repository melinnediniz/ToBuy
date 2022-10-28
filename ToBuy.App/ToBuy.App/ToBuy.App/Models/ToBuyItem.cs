using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToBuy.App.Models
{
    public class ToBuyItem
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
