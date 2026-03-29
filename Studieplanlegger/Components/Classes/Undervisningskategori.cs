using System.ComponentModel.DataAnnotations;

namespace Studieplanlegger.Components.Classes
{
    public class Undervisningskategori
    {
        [Required]
        int Id { get; set; }
        [Required]
        string Kategori { get; set; }= string.Empty;
        string Beskrivelse { get; set; } = string.Empty;
        [Required]
        int multipliseringsfaktor { get; set; }
    }
}
