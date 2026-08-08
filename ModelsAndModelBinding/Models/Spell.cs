using System.ComponentModel.DataAnnotations;

namespace ModelsAndModelBinding.Models
{
    /// <summary>
    /// Represents an individual magical spell in the grimoire, containing its attributes, level, and mana requirements for casting.
    /// </summary>
    public class Spell
    {
        /// <summary>
        /// The unique identifier and primary key for the spell.
        /// </summary>
        public int SpellId { get; set; }

        /// <summary>
        /// The user-facing name of the spell, limited to a maximum of 40 characters.
        /// </summary>
        [Required(ErrorMessage = "Please enter the name of the spell.")]
        [StringLength(40, ErrorMessage = "Spell name cannot exceed 40 characters.")]
        public required string Name { get; set; }

        /// <summary>
        /// The primary school or branch of magic (e.g., Evocation, Abjuration, Illusion) that classifies the spell, up to 30 characters.
        /// </summary>
        [Required(ErrorMessage = "Please specify the school of magic.")]
        [StringLength(30, ErrorMessage = "School of magic cannot exceed 30 characters.")]
        public required string School {  get; set; }

        /// <summary>
        /// The spell level ranging from 0 (Classless) to 8 (Max Ascension).
        /// </summary>
        [Range(0, 8, ErrorMessage = "Spell level must be between 0 and 8")]
        public int Level { get; set; }


        /// <summary>
        /// The rarity tier of the spell (1 = Common, 2 = Rare, 3 = Legendary, 4 = Mythical, 5 = Divine, 6 = Immortal).
        /// </summary>
        [Range(1, 6, ErrorMessage = "Rarity tier must be between 1 (Common) and 6 (Immortal).")]
        public int Rarity {  get; set; }

    }
}
