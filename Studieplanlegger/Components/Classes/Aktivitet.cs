using System.ComponentModel.DataAnnotations;

namespace Studieplanlegger.Components.Classes
{
    public class Aktivitet
    {
        [Required]
        int Id { get; set; }
        [Required]
        string Beskrivelse { get; set; } = string.Empty;
        [Required]
        DateOnly Dato { get; set; }
        [Required]
        int AntallTimer { get; set; }
        int BeregnetTid { get; set; }
        [Required]
        int UndervisningsKategoriId { get; set; }
        [Required]
        string Emnekode { get; set; } = string.Empty;
        [Required]
        string UndervisersEpost { get; set; } = string.Empty;  
    }
}
