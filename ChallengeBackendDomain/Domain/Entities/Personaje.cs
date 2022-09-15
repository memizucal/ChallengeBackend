using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeBackendDomain
{
    public class Personaje
    {
        public byte[] Imagen { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int Peso { get; set; }
        public string Historia { get; set; }

    }
}
