using System.ComponentModel.DataAnnotations;

namespace Studieplanlegger.Components.Classes
{
    public class Fagfelt
    {
        [Required]
        int FagfeltID { get; set; }

        [Required]
        string FagfeltNavn { get; set; }

        string Beskrivelse { get; set; }
         [Required]
         int FagenhetID { get; set; }
    }
}
