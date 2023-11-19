using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.ApplicationCore.Domain
{
    public class Conseiller
    {
        public int ConseillerId { get; set; }
        public string nom { get; set; }

        public string prenom { get;set; }
        public IList<Client> Clients { get; set; }
    }
}
