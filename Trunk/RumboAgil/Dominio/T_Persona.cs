//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dominio
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_Persona
    {
        public T_Persona()
        {
            this.T_Participante = new HashSet<T_Participante>();
        }
    
        public short Id_Persona { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public Nullable<System.DateTime> Cumpleaños { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public bool Bautizado { get; set; }
    
        public virtual T_Lider T_Lider { get; set; }
        public virtual T_Miembro T_Miembro { get; set; }
        public virtual ICollection<T_Participante> T_Participante { get; set; }
        public virtual T_Usuario T_Usuario { get; set; }
    }
}
