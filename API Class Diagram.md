```mermaid
---
title: Character Chronicle Class Diagram
---
classDiagram
    direction TD
    class Character{
        string characterName 
        int level
        int currentXP
        int currentGold
        Species species
        CharacterClass characterClass
        AbilityScores abilityScores
        string characterDescription
        Dictionary~string, IEquipment~ equipment
        Dictionary~ACEnum, int~ armorClass 
        Dictionary~string, IWeapon~ weapons
        int age
        AlignmentEnum alignment
        List~string~ learnedLanguages
        ICharacterCreationStep currentStep
        List~ICharacterCreationStep~ allSteps
        RollStats()
        GetSteps()
        NextStep()
        PreviousStep()
        ArbitraryStep()
        SaveCharacter()
        LoadCharacter()
        ExportToPDF()
    }    
    
    class ParantSpecies{
        <<ISpecies>>
    }
    
    class SubSpecies{
        <<ISpecies>>
    }
    
    class SpeciesTrait{
        <<ISpeciesTrait>>
    }

    class CharacterClass{
        <<ICharacterClass>>
    }

    class CharacterCreationStep{
        <<ICharacterCreationStep>>
    }

    class ChooseProficiencies{
        <<ICharacterCreationStep>>
    }

    class ChooseSavingThrows{
        <<ICharacterCreationStep>>
    }

    class ChooseClassFeatures{
        <<ICharacterCreationStep>>
    }

    class ChooseSkills{
        <<ICharacterCreationStep>>
    }

    class ChooseSpells{
        <<ICharacterCreationStep>>
    }

    class ChooseAlignment{
        <<ICharacterCreationStep>>
    }

    class ChooseLanguages{
        <<ICharacterCreationStep>>
    }

    class ChooseBackground{
        <<ICharacterCreationStep>>
    }

    class ChooseEquipment{
        <<ICharacterCreationStep>>
    }

    class ChooseFeats{
        <<ICharacterCreationStep>>
    }

    class ClassFeatures

    class Skills

    class Spell

    class Equipment{
        <<IEquipment>>
    }

    class Armor{
        <<IEquipment>>
        <<IArmor>>
    }

    class Weapon{
        <<IEquipment>>
        <<IWeapon>>
    }
 ```