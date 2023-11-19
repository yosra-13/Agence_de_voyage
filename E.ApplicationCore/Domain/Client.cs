using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.ApplicationCore.Domain
{
    public class Client
    {
        [Key]
        public int Identifiant { get; set; }
        [Required(ErrorMessage = "La propriété  est obligatoire.")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Le champ Mot de passe est obligatoire.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Photo { get; set; }
        public int ConseillerFk { get; set; }

        public IList<Reservation> Reservations { get; set; }

        public Conseiller Conseiller { get; set; }

    }
}
