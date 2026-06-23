using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Player class - Represents game player data
/// </summary>
[System.Serializable]
public class Player
{
    public string username;
    public string email;
    public string country;
    public int level = 1;
    public int coins = 500;
    public int gems = 0;
    public int experience = 0;
    public int reputation = 0;
    public string careerPath = "Student";
    
    // Attributes
    public int intelligence = 5;
    public int communication = 5;
    public int negotiation = 5;
    public int ethics = 5;
    public int research = 5;
    public int advocacy = 5;
    public int leadership = 5;

    // Skills
    public Dictionary<string, int> skills = new Dictionary<string, int>()
    {
        { "Negotiation", 1 },
        { "Advocacy", 1 },
        { "Research", 1 },
        { "Drafting", 1 },
        { "Mediation", 1 },
        { "Arbitration", 1 },
        { "Leadership", 1 },
        { "Diplomacy", 1 }
    };

    // Career levels
    public List<string> careerLevels = new List<string>()
    {
        "Secondary School Student",
        "University Student",
        "Law Student",
        "Intern",
        "Pupil Barrister",
        "Junior Lawyer",
        "Associate Lawyer",
        "Senior Associate",
        "Partner",
        "Managing Partner",
        "Senior Counsel",
        "Judge",
        "Attorney General",
        "International Arbitrator",
        "Global Legal Icon"
    };

    public Player(string username, string email, string country)
    {
        this.username = username;
        this.email = email;
        this.country = country;
    }

    public void AddCoins(int amount)
    {
        coins += amount;
    }

    public void AddExperience(int amount)
    {
        experience += amount;
    }

    public void UpgradeSkill(string skillName)
    {
        if (skills.ContainsKey(skillName))
        {
            skills[skillName]++;
        }
    }
}
