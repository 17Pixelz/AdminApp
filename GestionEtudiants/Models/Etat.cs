using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models
{
    public class Etat
    {
        [Key]
        public int Id { get; set; }

        public int etat { get; set; }
    }
}
