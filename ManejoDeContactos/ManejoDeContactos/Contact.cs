using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeContactos
{

    public class Contact
    {

        /// Nombre del contacto (primer nombre).
    
        public string FirstName { get; set; }


        /// Apellido del contacto.
 
        public string LastName { get; set; }

 
        /// Dirección del contacto.
    
        public string Address { get; set; }

         /// Correo electrónico.
          public string Email { get; set; }

        /// Lista de teléfonos. Puede ser vacía.

        public List<string> Phones { get; set; } = new List<string>();


        /// Conjunto de palabras clave para facilitar búsquedas.
        /// Se recomienda incluir el nombre y apellido aquí.

        public HashSet<string> Keywords { get; set; } = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

 
        /// Nombre completo (concatenación) para mostrar en la UI.

        public string DisplayName => $"{FirstName} {LastName}";
    }
}
