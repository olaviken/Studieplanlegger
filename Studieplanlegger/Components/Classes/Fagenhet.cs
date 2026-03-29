using System.ComponentModel.DataAnnotations;

namespace Studieplanlegger.Components.Classes
{
    public class Fagenhet
    {
        [Required]
        int FagenhetID { get; set; }

        [Required]
        string FagenhetNavn { get; set; } = string.Empty;

        string Fagenhetsleder { get; set; } = string.Empty;

        string Beskrivelse { get; set; } = string.Empty;

        [Required]
        int InstituttID { get; set; }
    }
}
