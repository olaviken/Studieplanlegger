using System.ComponentModel.DataAnnotations;

namespace Studieplanlegger.Components.Classes
{
    public class Institutt
    {
        [Required]
        int Id { get; set; }
        [Required]
        string Name { get; set; }
        string Leder { get; set; }
        string Beskrivelse { get; set; }

        [Required]
        int FakultetId { get; set; }
    }
}
