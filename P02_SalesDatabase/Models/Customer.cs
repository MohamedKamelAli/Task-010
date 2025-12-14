using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        [MaxLength(100)]
        [Unicode]
        public string Name { get; set; }

        [Required]
        [MaxLength(80)]
        [Unicode(false)]
        public string Email { get; set; }
        public string CreaditCardNumber { get; set; }

        public List<Sale> Sales { get; set; }


    }
}
