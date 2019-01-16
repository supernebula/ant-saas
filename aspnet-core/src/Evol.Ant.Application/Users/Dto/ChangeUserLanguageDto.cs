using System.ComponentModel.DataAnnotations;

namespace Evol.Ant.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}