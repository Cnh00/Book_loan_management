
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
namespace projet.Model{ 

public class Event {

    [Key]
    public int idEvent { get; set; }

    public String Ville { get; set; }

    public float Note { get; set; }

    public DateTime dateDebut { get; set; }

    public DateTime dateFin { get; set; }

    public int nombreMax { get; set; }

    public String descriptionEvent { get; set; }

    public String nomEvent { get; set; }

    public float prix { get; set; }

    public String type { get; set; }

    public virtual ICollection<Activite> activities { get; set; }

    public string cin ;

    public virtual Guide Guide { get; set; }

    public virtual List<Client> utilisateurs { get; }
    
    
        public Event()
        {
            activities = new List<Activite>();      
            utilisateurs = new List<Client>();  
        }
        



    }
}