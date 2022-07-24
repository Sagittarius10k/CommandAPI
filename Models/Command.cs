using System.ComponentModel.DataAnnotations;

namespace dotnet_rpg.Models
{
    public class Command
    {
        [Key]
        [Required]
        public int CommandId {get; set;}

        [Required]
        [MaxLength(250)]
        public string HowTo {get; set;} = "";

        [Required]
        public string Platform {get; set;} = "";

        [Required]
        public string CommandLine {get; set;} = "";
    }
}