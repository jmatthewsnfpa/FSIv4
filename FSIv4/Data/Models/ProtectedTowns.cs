using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FSIv4.Data.Models
{
    public class ProtectedTowns
    {
        private const string DefaultStringValue = "";

        [Key]
        public int TownProtectedId { get; set; }

        [Required(ErrorMessage = "The Protected Town Name field is required.")]
        public string TownProtectedName { get; set; } = DefaultStringValue;

        [Required]
        [ForeignKey("FsiRecord")] // Foreign key to link to the FSI table
        public int NfpaFdid { get; set; }

        [Required(ErrorMessage = "The Fire Department Name field is required.")]
        public string FdName { get; set; } = DefaultStringValue;

        public string? City { get; set; } = DefaultStringValue;
        [Required(ErrorMessage = "The State field is required.")]
        public EnumList.StateList State { get; set; }
        public int StateId { get; set; }
        public int StateGroup { get; set; }
        public int? StateGroupOverride { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime CreatedDt { get; set; } = DateTime.Now;

        [Required]
        [DataType(DataType.Date)]
        public DateTime UpdatedDt { get; set; } = DateTime.Now;

        // Navigation property to the FSI table
        public FSI? FsiRecord { get; set; }
    }
}
