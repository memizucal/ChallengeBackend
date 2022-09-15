using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChallengeBackend
{
    [Table("Personaje")]
    public class Personaje
    {
        [Key]
        public int PersonajeId { get; set; }
        public byte[] Imagen {get; set;}
        public string Nombre {get; set;}
        public int Edad { get; set;}
        public int Peso { get; set;}
        public string Historia { get; set;}  
        public virtual ICollection<PelículaOSerie> PelículaOSerie { get; set; }
        
    }
}
