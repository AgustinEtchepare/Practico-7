//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practica7aa
{
    using System;
    using System.Collections.Generic;
    
    public partial class Personajes
    {
        public int Per_id { get; set; }
        public Nullable<int> Per_LibId { get; set; }
        public Nullable<int> Per_RolId { get; set; }
        public string Per_Nombre { get; set; }
        public string Per_Apellido { get; set; }
        public string Per_Descripcion { get; set; }
        public Nullable<System.DateTime> Per_FechaNacimiento { get; set; }
        public string Per_LugarNacimiento { get; set; }
        public string Per_Status { get; set; }
    
        public virtual Libro Libro { get; set; }
        public virtual Roles Roles { get; set; }
    }
}