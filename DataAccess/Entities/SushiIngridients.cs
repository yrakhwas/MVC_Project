using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class SushiIngridients
    {
        public int SushiId { get; set; }
        public Sushi? Sushi { get; set; }
        public int IngridientId { get; set; }
        public Ingridient Ingridient { get; set; }
    }
}
