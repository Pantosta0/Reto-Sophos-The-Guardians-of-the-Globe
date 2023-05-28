using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Pelea : AuditableBaseEntity
    {
       
        public virtual int IdHeroe { get; set; }
        public virtual int IdVillano { get; set; }
        public virtual bool Victoria_heroes { get; set; }

        public virtual bool Victoria_villanos { get; set; }  
    }
}
