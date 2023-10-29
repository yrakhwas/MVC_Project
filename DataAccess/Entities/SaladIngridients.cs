using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class SaladIngridients
    {
        public int SaladId { get; set; }
        public Salad Salad { get; set; }
        public int IngridientId { get; set; }
        public Ingridient Ingridient { get; set; }
    }
}
