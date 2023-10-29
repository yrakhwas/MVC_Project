using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Ingridient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Pizza ?[]Pizzas { get; set; }
        public Sushi?[] Sushis {  get; set; }
        public Salad?[] Salads {  get; set; } 
    }
}
