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
        public Pizza?[] Pizza { get; set; }
        public Salad?[] Salad { get; set; }
        public Sushi?[] Sushis { get; set; }
    }
}
