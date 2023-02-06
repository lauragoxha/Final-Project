using System.ComponentModel.DataAnnotations;
using System;

namespace StudentApp.Data.Models
{
    public class Book : BaseClass
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateSold  { get; set; }
        public int Price { get; set; }
    }
}
