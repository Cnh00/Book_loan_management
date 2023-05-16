using System.ComponentModel.DataAnnotations;

namespace projet.Model
{
    public class Ville
    {
        
        [Key]
        public int idVille { get; set; }

        public String nomVille { get; set; }

        public String codePostal { get; set; }

        public virtual ICollection<Activite> Activites { get; set; }
        public Ville()
        {
            Activites = new List<Activite>();

        }

    }
}
