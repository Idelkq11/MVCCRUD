using System;

namespace MVCCRUD.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public DateTime? Fecha { get; set; }
        public string Clave { get; set; } = string.Empty;
    }
} 
