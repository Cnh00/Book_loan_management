
using projet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Guide : userDTO {

    public virtual ICollection<Event> evenements { get; set; }
    public Guide() 
    {
        evenements = new List<Event>();
    }

   

}