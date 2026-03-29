using System.ComponentModel.DataAnnotations;

namespace Studieplanlegger.Components.Classes
{
    public class Ansatt
    {
        [Required]
        string Epost { get; set; } = string.Empty;
                
        [Required]
        string Etternavn { get; set; } = string.Empty;
        
        [Required]
        string Fornavn { get; set; } = string.Empty;

        [Required]
        DateOnly Fødselsdato { get; set; }

        int Stillingsprosent { get; set; }
        
        int RNDprosent { get; set; }
        string Spesialisering { get; set; } = string.Empty;

        [Required]
        int FagenhetID { get; set; }   
    }
}
