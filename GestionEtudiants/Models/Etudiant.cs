using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEtudiants.Models
{
    public class Etudiant
    {
        [Key]
        public int apogee { get; set; }
        public string cne { get; set; }
        public string email { get; set; }
        public string cin { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public DateTime ddn { get; set; }
        public string ldn { get; set; }
        public string natio { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string annee { get; set; }


            
        public int classeId { get; set; }
        [ForeignKey("classeId")]
        public Classe classe { get; set; }

        public string picture { get; set; }
        public string password { get; set; }
        public string sexe { get; set; }

        public Etudiant(int apogee, string lastname, string firstname, string email, string annee, int classeId)
        {
            this.apogee = apogee;
            this.lastname = lastname;
            this.firstname = firstname;
            this.email = email;
            this.annee = annee;
            this.classeId = classeId;
        }
  

        public Etudiant(int apogee, string lastname, string firstname, string email, string annee,int classeId,string picture)
        {
            this.apogee = apogee;
            this.lastname = lastname;
            this.firstname = firstname;
            this.email = email;
            this.annee = annee;
            this.classeId = classeId;
            this.picture = picture;
        }

        public Etudiant() { }
        
        

    }
}
