using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class User
    {
        public int CredentialsId { get; set; }
        public Credentials Credentials { get; set; }
        public List<Pizza>? Pizzas { get; set; }
        public List<Salad>? Salad { get; set; }
        public List<Sushi>? Sushis { get; set; }
    }
}
