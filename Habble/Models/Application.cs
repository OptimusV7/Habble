using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Habble.Models
{
    public class Application
    {
        [Key]
        public int ApplicaitonId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "Firstname is Required")]
        public string? Firstname { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "Lastname is Required")]
        public string? Lastname { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "Email is Required")]
        public string Email { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "TypeOfProject is Required")]
        public string? TypeOfProject { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Budget should be greater than zero")]
        public int Budget { get; set; }
        [Required(ErrorMessage = "TimeFrame is Required")]
        public int? TimeFrame { get; set; }
        [Required(ErrorMessage = "Privacy is Required")]
        public bool AcceptedPrivacy { get; set; }

    }
}
