using System.ComponentModel.DataAnnotations;

namespace ModelsAndModelBinding.Models
{
    /// <summary>
    /// Represents an individual magical spell in the grimoire, containing its attributes, level, and mana requirements for casting.
    /// </summary>
    public class Spell
    {
        public int SpellId { get; set; }

        [Required(ErrorMessage = "Please enter the name of the spell.")]
        [StringLength(40, ErrorMessage = "Spell name cannot exceed 40 characters.")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Please specify the school of magic.")]
        [StringLength(30, ErrorMessage = "School of magic cannot exceed 30 characters.")]
        public required string School {  get; set; }

        [Range(0, 9, ErrorMessage = "Spell level must be between 0 and 9")]
        public int level { get; set; }

        [Range(0, 100, ErrorMessage = "Mana cost must be between 0 and 100")]
        public int ManaCost {  get; set; }

    }
}
