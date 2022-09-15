using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChallengeBackend
{
    [Table("PelículaOSerie")]
    public class PelículaOSerie
    {
        [Key]
        public int PelículaOSerieId { get; set; }
        public byte[] Imagen { get; set; }
        public string Título { get; set; }
        public DateTime FechaDeCreación { get; set; }
        public int Calificación { get; set; }
        public virtual ICollection<Personaje> Personaje { get; set; }
    }
}