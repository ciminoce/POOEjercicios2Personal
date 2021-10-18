using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOEjercicios2Personal
{
    class Program
    {
        static void Main(string[] args)
        {
            var empleado = new Empleado()
            {
                Apellido = "Harrison",
                Nombres = "George",
                FechaNacimiento = new DateTime(1970, 10, 27),
                Telefono = "2227-422222",
                Sector = Sector.Administracion
            };
            var cliente = new Cliente()
            {
                Apellido = "Star",
                Nombres = "Alina",
                Telefono = "2224-432310",
                Mail = "alinastar@gmail.com"
            };
            Console.WriteLine(cliente.GetInfo());
            Console.WriteLine(empleado.GetEdad());
            Console.WriteLine(empleado.GetInfo());
            Console.ReadLine();

        }
    }
}
