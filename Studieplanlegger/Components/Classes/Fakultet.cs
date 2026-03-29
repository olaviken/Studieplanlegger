using System.ComponentModel.DataAnnotations;

namespace Studieplanlegger.Components.Classes
{
    public class Fakultet
    {
        [Required]
        int Organisasjonsnummer { get; set; }  
        [Required]
        string Navn { get; set; }=string.Empty;

        string Leder { get; set; }=string.Empty;
        string Beskrivelse { get; set; }=string.Empty;

    }
}
