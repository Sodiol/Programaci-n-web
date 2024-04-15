using System.ComponentModel.DataAnnotations;

namespace Examen_1P.Data
{
    public class Producto
    {

        [Required(ErrorMessage = "Debe ser entero positivo mayor a 0")]
        [Range(1, int.MaxValue, ErrorMessage = "El número de inventario debe ser un número entero positivo.")]
        public int NumeroInventario { get; set; }

        [Required(ErrorMessage = "El nombre no debe ser vacío")]
            public string Nombre { get; set; }

        [Required(ErrorMessage ="Debe seleccionar departamento")]
            public string? Departamento { get; set; }
        

    }
}
