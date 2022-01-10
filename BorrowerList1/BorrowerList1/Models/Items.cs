﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BorrowerList1.Models
{
    public class Items
    {
        [Key]
        public int Id { get; set; }
        public string Borrower { get; set; }
        public string Lender { get; set; }
        [DisplayName("Item name")]
        public string ItemName { get; set; }
    }
}
