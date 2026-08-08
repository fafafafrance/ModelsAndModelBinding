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
        [StringLength(40, ErrorMessage = "Spell name cannot exceed 40 characters")]
        public required string Name { get; set; }

    }
}
