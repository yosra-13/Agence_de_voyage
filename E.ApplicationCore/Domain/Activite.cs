using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.ApplicationCore.Domain
{
    public class Activite
    {
        [Key]
        public int ActivateId { get; set; }

        public Zone Zone { get; set; }
        public double Prix { get; set; }
        public string TypeService { get; set; }
        public IList<Pack> Packs { get; set; }



    }
}
