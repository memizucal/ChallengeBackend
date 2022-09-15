using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChallengeBackend
{
    [Table("Género")]
    public class Género
    {
        [Key]
        public int GéneroId { get; set; }
        public string Nombre { get; set; }
        public byte[] Imagen { get; set; }

        [ForeignKey("PelículaOSerie")]
        public virtual ICollection<PelículaOSerie> PelículaOSerie { get; set; }

    }
}
