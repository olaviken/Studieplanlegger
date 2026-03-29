using System.ComponentModel.DataAnnotations;

namespace Studieplanlegger.Components.Classes
{
    public class Emne
    {
        [Required]
        string emnekode { get; set; } = string.Empty;
        
        [Required]
        string emnenavn { get; set; } = string.Empty;

        string beskrivelse { get; set; } = string.Empty;
        
        [Required]
        int FagfeltID { get; set; }

    }
}
