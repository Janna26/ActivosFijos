//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mantenimientos
{
    using System;
    using System.Collections.Generic;
    
    public partial class ActivoFijo
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Departamento { get; set; }
        public string Ubicacion { get; set; }
        public string tipoActivo { get; set; }
        public System.DateTime fechaRegistro { get; set; }
        public int valorCompra { get; set; }
        public string depreciacionAcumulada { get; set; }
    }
}