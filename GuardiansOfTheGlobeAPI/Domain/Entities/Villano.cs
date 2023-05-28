using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Villano : AuditableBaseEntity
    { 
        public virtual string NombreVillano { get; set; } = string.Empty;
        public virtual string Nombre { get; set; } = string.Empty;
        public virtual int Edad { get; set; }
        public virtual string Origen { get; set; } = string.Empty;
        public virtual string Habilidades { get; set; } = string.Empty;
        public virtual string Debilidades { get; set; } = string.Empty;
        public virtual string Poder { get; set; } = string.Empty;

        public virtual ICollection<Pelea> Peleas { get; set; }
    }
}
