using System.ComponentModel.DataAnnotations;

namespace MuenYang.SMZG.Configuration.Dto
{
    public class ChangeUiThemeInput
    {
        [Required]
        [MaxLength(32)]
        public string Theme { get; set; }
    }
}