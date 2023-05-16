
using projet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Client : userDTO {

    public virtual ICollection<Event> evenements { get; set; }
    public Client() 
    {
        evenements = new List<Event>();
    }

   

}