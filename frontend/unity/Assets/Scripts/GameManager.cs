using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Main Game Manager - Persists across scenes
/// Manages global game state, player data, and game flow
/// </summary>
public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    // Player Data
    public string playerName = "New Player";
    public int playerLevel = 1;
    public int coins = 500;
    public int experience = 0;
    public int reputation = 0;
    public string careerPath = "Student";

    // Game State
    public bool isPaused = false;
    public bool isInCourt = false;

    void Awake()
    {
        // Singleton pattern - only one GameManager exists
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        Debug.Log($"Game Started - Player: {playerName}, Level: {playerLevel}");
        LoadPlayerData();
    }

    // =====================
    // PLAYER MANAGEMENT
    // =====================

    public void LoadPlayerData()
    {
        // Load from local storage or database
        Debug.Log("Loading player data...");
    }

    public void SavePlayerData()
    {
        // Save to local storage or database
        Debug.Log("Saving player data...");
    }

    public void GainCoins(int amount)
    {
        coins += amount;
        Debug.Log($"Gained {amount} coins. Total: {coins}");
    }

    public void GainExperience(int amount)
    {
        experience += amount;
        Debug.Log($"Gained {amount} experience. Total: {experience}");
    }

    public void LevelUp()
    {
        playerLevel++;
        Debug.Log($"Leveled up! New level: {playerLevel}");
    }

    // =====================
    // GAME STATE
    // =====================

    public void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0f;
        Debug.Log("Game Paused");
    }

    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1f;
        Debug.Log("Game Resumed");
    }

    // =====================
    // SCENE MANAGEMENT
    // =====================

    public void LoadScene(string sceneName)
    {
        Debug.Log($"Loading scene: {sceneName}");
        SceneManager.LoadScene(sceneName);
    }

    public void LoadGameScene()
    {
        LoadScene("GameScene");
    }

    public void LoadMenuScene()
    {
        LoadScene("MenuScene");
    }

    public void Quit()
    {
        SavePlayerData();
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
