using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Patrocinador : AuditableBaseEntity
    {
        public int IdHeroe { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string OrigenDinero { get; set; } = string.Empty;
        public double Monto { get; set; }
        
        

        public ICollection<Heroe> Heroes { get; set; }
    }
}
