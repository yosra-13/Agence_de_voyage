using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.ApplicationCore.Domain
{
    public class Reservation
    {
        [DataType(DataType.Date)]
        public DateTime DateReservation { get; set; }
        [MaxLength(4),MinLength(1)]
        public int NbPersonnes { get; set; }
        public int PackFk { get; set; }
        [ForeignKey("PackFk")]
        public Pack Pack { get; set; }
        public int ClientFk { get; set; }
        [ForeignKey("ClientFk")]
        public Client Client { get; set; }

    }
}
