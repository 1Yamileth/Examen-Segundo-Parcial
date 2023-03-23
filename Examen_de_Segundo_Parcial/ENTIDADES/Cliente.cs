using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Cliente
    {
        //PROPIEDADES
        public string IdentidadCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public Cliente()
        {
        }

        public Cliente(string identidadCliente, string nombre, string apellido, string telefono, string email)
        {
            IdentidadCliente = identidadCliente;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Email = email;
        }
    }
}
