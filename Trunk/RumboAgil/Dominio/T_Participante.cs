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
    
    public partial class T_Participante
    {
        public short Id_Persona { get; set; }
        public short Id_Evento { get; set; }
        public string Responsabilidad { get; set; }
    
        public virtual T_Evento T_Evento { get; set; }
        public virtual T_Persona T_Persona { get; set; }
    }
}
