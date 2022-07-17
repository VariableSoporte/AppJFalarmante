using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class PersonaEntidad
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string Apellido { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }

        public PersonaEntidad()
        {
                
        }

        public PersonaEntidad(int id, string nombre, string apellido, string usuario, string contraseña)
        {
            this.id = id;
            this.nombre = nombre;
            Apellido = apellido;
            this.usuario = usuario;
            this.contraseña = contraseña;
        }
    }
}
