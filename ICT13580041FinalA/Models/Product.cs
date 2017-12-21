using System;
using SQLite;
namespace ICT13580041FinalA.Models
{
    public class Product
    {
        [PrimaryKey , AutoIncrement]
        public int Id {get;set;}

        [NotNull]
        [MaxLength(200)]
        public string   Name  { get; set; }


		[NotNull]
		[MaxLength(200)]
        public string LastName { get; set; }

        public int  Age { get; set; }

        [NotNull]
        public string Sax { get; set; }

        public string Part { get; set; }

        public int Phone { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string Status { get; set; }

        public decimal Sun { get; set; }

        public int Salary { get; set; }






    }
}
