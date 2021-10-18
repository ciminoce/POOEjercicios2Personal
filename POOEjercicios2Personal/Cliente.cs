using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POOEjercicios2Personal
{
    public class Cliente : Persona
    {

        public string Mail { get; set; }
        public override string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cliente: {Nombres} {Apellido}");
            sb.AppendLine($"Teléfono: {Telefono}");
            sb.AppendLine($"Mail: {Mail}");
            return sb.ToString();
        }
    }
}