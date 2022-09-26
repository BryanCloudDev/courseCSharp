using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace automovil.Models.DataModels
{
    public class Curso : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [Required, StringLength(280)]
        public string ShortDescription { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required]
        public string ObjectivePublic { get; set; } = string.Empty;
        [Required]
        public string Objective { get; set; } = string.Empty;
        [Required]
        public string Requirements { get; set; } = string.Empty;
        [Required]
        public string Level { get; set; } = string.Empty;
    }
}
