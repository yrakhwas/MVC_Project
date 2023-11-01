using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Salad
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Ingridient> Ingridients { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public decimal Cost
        {
            get
            {
                return CalculateCost();
            }
            set
            {
                CalculateCost();
            }
        }
        public decimal CalculateCost()
        {
            decimal cost = Ingridients.Sum(i => i.Price);
            return cost;
        }
    }
}
