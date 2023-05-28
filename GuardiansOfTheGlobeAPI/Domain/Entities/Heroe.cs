using Domain.Common;

namespace Domain.Entities
{
    public class Heroe : AuditableBaseEntity
    {
        private string _grupoEdad;
        public virtual string NombreSuper { get; set; } = string.Empty;
        public virtual string Nombre { get; set; } = string.Empty;
        public virtual int Edad { get; set; }
        public virtual string Sexo { get; set; } = string.Empty;
        public virtual string GrupoEdad
        {
            get
            {
                if (Edad <18)
                {
                    _grupoEdad = "Adolescente";
                    return _grupoEdad;
                }else
                {
                   _grupoEdad = "Adulto";
                    return _grupoEdad;
                }
                
            }
        }
        public virtual string Habilidades { get; set; } = string.Empty;
        public virtual string Debilidades { get; set; } = string.Empty;
        public virtual string RelacionesPersonales { get; set; } = string.Empty;
        public virtual int PatrocinadorId { get; set; }
        public virtual ICollection<Patrocinador> Patrocinadores { get; set; }   
        public virtual ICollection<Agenda> Agendas { get; set;}
        public virtual ICollection<Pelea> Peleas { get; set; }  

    }
}
