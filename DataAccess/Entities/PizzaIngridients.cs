using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class PizzaIngridients
    {
        public int PizzaId { get; set; }
        public Pizza Pizza { get; set; }
        public int IngridientId { get; set; }
        public Ingridient Ingridient { get; set; }
    }
}
