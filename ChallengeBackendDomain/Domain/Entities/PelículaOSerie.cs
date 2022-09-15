using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeBackendDomain.Domain
{
    internal class PelículaOSerie
    {
        public byte[] Imagen { get; set; }
        public string Título { get; set; }
        public string FechaDeCreación { get; set; }
        public int Calificación { get; set; }

    }
}
