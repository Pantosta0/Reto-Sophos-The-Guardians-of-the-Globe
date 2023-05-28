using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Agenda : AuditableBaseEntity
    {
        
        [ForeignKey("IdHeroe")]
        public virtual int IdHeroe { get; set; }
        public virtual DateTime Fecha { get; set; }
        public virtual string Actividad { get; set; } = string.Empty;
    }
}
