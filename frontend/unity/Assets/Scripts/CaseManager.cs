using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Manages legal cases in the game
/// Handles case loading, progression, and verdicts
/// </summary>
public class CaseManager : MonoBehaviour
{
    public static CaseManager instance;
    public List<LegalCase> availableCases = new List<LegalCase>();
    public LegalCase currentCase;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        LoadCases();
    }

    // =====================
    // CASE MANAGEMENT
    // =====================

    void LoadCases()
    {
        // Sample cases - In production, load from database
        availableCases.Add(new LegalCase
        {
            caseID = 1,
            title = "The Theft at Freetown Market",
            category = "Criminal Law",
            difficulty = 1,
            description = "A merchant reports theft of goods worth 50 million Leones. Your job is to investigate and determine the culprit.",
            rewardCoins = 1000,
            rewardExperience = 50
        });

        availableCases.Add(new LegalCase
        {
            caseID = 2,
            title = "Boundary Dispute in Bo District",
            category = "Land Law",
            difficulty = 2,
            description = "Two farmers claim ownership of the same plot of land. Review documents and determine rightful owner.",
            rewardCoins = 1500,
            rewardExperience = 75
        });

        availableCases.Add(new LegalCase
        {
            caseID = 3,
            title = "Contract Breach - Building Company",
            category = "Contract Law",
            difficulty = 2,
            description = "A construction company failed to complete a project on time. Client suing for damages.",
            rewardCoins = 2000,
            rewardExperience = 100
        });

        Debug.Log($"Loaded {availableCases.Count} cases");
    }

    public void SelectCase(int caseID)
    {
        currentCase = availableCases.Find(c => c.caseID == caseID);
        if (currentCase != null)
        {
            Debug.Log($"Case selected: {currentCase.title}");
        }
    }

    public void StartCase()
    {
        if (currentCase != null)
        {
            Debug.Log($"Starting case: {currentCase.title}");
            GameManager.instance.isInCourt = true;
        }
    }

    public void SubmitVerdict(string verdict)
    {
        if (currentCase != null)
        {
            Debug.Log($"Verdict submitted for {currentCase.title}: {verdict}");
            
            // Award rewards
            GameManager.instance.GainCoins(currentCase.rewardCoins);
            GameManager.instance.GainExperience(currentCase.rewardExperience);
            
            GameManager.instance.isInCourt = false;
            currentCase = null;
        }
    }
}

/// <summary>
/// Represents a legal case
/// </summary>
[System.Serializable]
public class LegalCase
{
    public int caseID;
    public string title;
    public string category;
    public int difficulty;
    public string description;
    public int rewardCoins;
    public int rewardExperience;
}
