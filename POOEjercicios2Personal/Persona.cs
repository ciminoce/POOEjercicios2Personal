using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POOEjercicios2Personal
{
    public class Persona
    {
        public string Apellido { get; set; }
        

        public string Nombres { get; set; }
        
        public string Telefono { get; set; }
        

        public virtual string GetInfo()
        {
            return $"{Nombres} {Apellido}";
        }
    }
}