using System.ComponentModel.DataAnnotations;

namespace projet.Model
{
    public class userDTO
    {
        [Key]
        public int id { get; set; }

        public String email { get; set; }

        public String Password { get; set; }
        
        protected string nom { get; set; }

        protected string prenom { get; set; }
        

        protected string numTel { get; set; }
    }
}
