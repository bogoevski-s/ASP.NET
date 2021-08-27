using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.E_store.Domain.Models
{
    public class Review
    {
        public int Id { get; set; }
        public Product ProductReview { get; set; }
        public string ReviewComment { get; set; }
        public User User { get; set; }
    }
}
