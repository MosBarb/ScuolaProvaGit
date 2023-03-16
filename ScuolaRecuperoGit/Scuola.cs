using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScuolaRecuperoGit
{
    internal class Scuola
    {
        public string NomeScuola { get; set; }
        public int OrarioApertura { get; set; }
        public int OrarioChiusura { get; set; }
        public List<Alunno> Alunni { get; set; } // Alunno sarà visto quando faremo il merge
    }
}
