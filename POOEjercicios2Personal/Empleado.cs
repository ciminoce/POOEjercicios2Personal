using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POOEjercicios2Personal
{
    public class Empleado : Persona
    {

        public System.DateTime FechaNacimiento { get; set; }
        

        public Sector Sector { get; set; }
        

        public int GetEdad()
        {
            return (int) Math.Truncate(DateTime.Today.Subtract(FechaNacimiento).TotalDays / 365.25);
        }

        public override string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine($"Empleado: {Nombres} {Apellido}");
            sb.AppendLine($"Sector: {Sector}");
            return sb.ToString();
        }
    }
}