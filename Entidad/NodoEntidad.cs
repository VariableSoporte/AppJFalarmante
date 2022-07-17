using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class NodoEntidad
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string contacto { get; set; }
        public string direccion { get; set; }
        public string latitud { get; set; }
        public string longitud { get; set; }
        public string zona { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }

        public NodoEntidad()
        {

        }

        public NodoEntidad(int id, string nombre, string contacto, string direccion, string latitud, string longitud, string zona, string usuario, string contraseña)
        {
            this.id = id;
            this.nombre = nombre;
            this.contacto = contacto;
            this.direccion = direccion;
            this.latitud = latitud;
            this.longitud = longitud;
            this.zona = zona;
            this.usuario = usuario;
            this.contraseña = contraseña;
        }
    }
}
