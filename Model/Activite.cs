
using projet.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

public class Activite {
    
    [Key]
    public int idActivite { get; set; }

   
    public TimeOnly heureDebut { get; set; }

    
    public TimeOnly heureFin { get; set; }

 
    public DateOnly date { get; set; }

    public String descriptionAct { get; set; }

    public String nomActivite { get; set; }

    public int idEvent;
    public int idVille;

    public virtual Event Event { get; set; }
    public virtual Ville Ville { get; set; }


    public Activite() {
        
    }

}