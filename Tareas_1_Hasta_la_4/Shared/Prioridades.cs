using System.ComponentModel.DataAnnotations;

namespace Tareas_1_Hasta_la_4.Shared
{
    internal class Prioridades
    {
        [Key]
        public int PrioridadesId { get; set; }
        [Required(ErrorMessage ="!Debe llenar este campo¡")]
        public string? Descripcion { get; set; }
        [Range(1,int.MaxValue, ErrorMessage ="!Los dias de compromiso deben ser mayor que 1¡")]
        public int DiasCompromiso { get; set; }
    }
}
