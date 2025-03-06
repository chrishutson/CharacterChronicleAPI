using CharacterChronicleAPI.Interfaces;
using CharacterChronicleAPI.Services;

namespace CharacterChronicleAPI.Models
{
    public class DandD5ECharacter
    {
        public long Id { get; set; }
        public string? characterName { get; set; }
        public int characterLevel { get; set; }
        public int currentXP { get; set; }
        public int currentGold { get; set; }
        public string? characterDescription { get; set; }
        public int age { get; set; }

        public ISpecies? species;
        public ICharacterClass? characterClass;
        public IAbilityScores? abilityScores;
        public Dictionary<string, IEquipment>? equipment;
        public AlignmentEnum? alignment;
        public List<string>? learnedLanguages;
        public ICharacterCreationStep? currentCreationStep;
        public List<ICharacterCreationStep>? allCreationSteps;
        public ICharacterService? _characterService;

    }
}
