# 🔧 ANDROID VERSION - COMPLETE SETUP GUIDE

**For: Beginners with no game dev experience**

---

## 📋 STEP 1: INSTALL REQUIRED SOFTWARE (1-2 Hours)

### 1.1 Download & Install Unity
```
1. Go to: https://unity.com/download
2. Click "Download Unity Hub"
3. Install Unity Hub
4. Open Unity Hub → Installs → Install Editor
5. Select "Unity 2022 LTS" (Long Term Support)
   - During installation, IMPORTANT: Check "Android Build Support"
   - Also check "Android SDK & NDK Tools"
6. Wait for installation (~15-20 GB)
```

### 1.2 Install Android Studio
```
1. Go to: https://developer.android.com/studio
2. Download Android Studio
3. Install it (default location is fine)
4. Open Android Studio
5. Go to: SDK Manager → SDK Tools
   - Install "Android SDK Platform 30" (or latest)
   - Install "Android Emulator"
   - Install "Android SDK Platform-Tools"
6. Note the SDK location (usually: C:\Users\YourName\AppData\Local\Android\sdk)
```

### 1.3 Install Java Development Kit (JDK)
```
1. Go to: https://www.oracle.com/java/technologies/downloads/
2. Download "JDK 17" (or latest LTS)
3. Install it (default location OK)
4. Verify installation:
   - Open Command Prompt/Terminal
   - Type: java -version
   - You should see: "java version 17.x.x"
```

---

## 📱 STEP 2: CONFIGURE UNITY FOR ANDROID (30 minutes)

### 2.1 Create New Unity Project
```
1. Open Unity Hub
2. Click "New Project"
3. Select "2D" template
4. Name: "LawEmpire-Mobile"
5. Location: Anywhere on your computer
6. Create Project
7. Wait for Unity to load (~5 minutes)
```

### 2.2 Switch Build Platform to Android
```
1. In Unity, go to: File → Build Settings
2. In "Platform" list on left, click "Android"
3. Click "Switch Platform" (wait 5-10 minutes)
4. You should see Android icon highlighted
```

### 2.3 Configure Android Settings
```
1. In Build Settings window:

2. Click "Player Settings" (bottom left)

3. Under "Android" section:
   
   a) Identification:
      - Package Name: com.simeonpangu.lawempire
      - Version: 1.0
      - Bundle Version Code: 1
   
   b) Minimum API Level: 24 (Android 7.0)
   
   c) Graphics:
      - Graphics APIs: OpenGL ES 3
   
   d) Input:
      - Touch Input: ON

4. In preferences (Edit → Preferences → External Tools):
   - Set Android SDK path (from Android Studio step)
   - Set JDK path
   - Set Gradle path
```

---

## 🎮 STEP 3: CREATE BASIC DEMO GAME (1-2 Hours)

### 3.1 Create Game Scenes

**Create Login Screen:**
```
1. File → New Scene
2. Rename to "LoginScene"
3. Save as: Assets/Scenes/LoginScene.unity

4. Create UI:
   - Right-click in Hierarchy → UI → Panel
   - Right-click Panel → UI → Text - TextMeshPro
   - Set text to: "Law Empire: Sierra Leone"
   - Right-click Panel → UI → Button - TextMeshPro
   - Label: "Start Game"

5. Save scene
```

**Create Main Game Scene:**
```
1. File → New Scene
2. Rename to "GameScene"
3. Save as: Assets/Scenes/GameScene.unity

4. Create basic UI:
   - Add text showing: "Level 1: Secondary School"
   - Add button: "Start Case"
   - Add display for coins: "Coins: 0"

5. Save scene
```

### 3.2 Create C# Scripts

**Create GameManager.cs:**
```csharp
File: Assets/Scripts/GameManager.cs

using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int playerLevel = 1;
    public int coins = 500;
    public string playerName = "New Player";

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void StartGame()
    {
        Debug.Log("Game Started!");
        SceneManager.LoadScene("GameScene");
    }

    public void GainCoins(int amount)
    {
        coins += amount;
        Debug.Log("Coins: " + coins);
    }
}
```

**Create UIManager.cs:**
```csharp
File: Assets/Scripts/UIManager.cs

using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI coinsText;
    public TextMeshProUGUI levelText;
    public TextMeshProUGUI nameText;

    void Start()
    {
        UpdateUI();
    }

    void UpdateUI()
    {
        if (GameManager.instance != null)
        {
            coinsText.text = "Coins: " + GameManager.instance.coins;
            levelText.text = "Level: " + GameManager.instance.playerLevel;
            nameText.text = GameManager.instance.playerName;
        }
    }

    public void OnStartCaseButtonClicked()
    {
        Debug.Log("Case Started!");
        GameManager.instance.GainCoins(100);
        UpdateUI();
    }
}
```

### 3.3 Connect Scripts to UI

```
1. In Hierarchy, create empty GameObject: "GameManager"
2. Drag GameManager.cs script onto it
3. Create another empty object: "UIManager"
4. Drag UIManager.cs onto it
5. In Inspector, drag UI text elements into the UIManager fields
6. On Start Case Button, set On Click event to UIManager.OnStartCaseButtonClicked()
```

---

## 🧪 STEP 4: TEST ON ANDROID EMULATOR (30 minutes)

### 4.1 Create Android Virtual Device (Emulator)
```
1. Open Android Studio
2. Go to: Tools → Device Manager
3. Click "Create Device"
4. Select: Pixel 4 (or any phone)
5. Select: Android 12 (API Level 31 or higher)
6. Finish creation
7. Click Play button to start emulator
8. Wait for it to boot (2-5 minutes)
```

### 4.2 Test in Unity
```
1. In Unity, go to: File → Build Settings
2. Ensure LoginScene is first in scene list
3. Click "Build And Run"
4. Select location to save APK
5. Unity will build and automatically run on emulator
6. Wait 3-5 minutes for build
7. Game should launch on emulator!
```

---

## 📲 STEP 5: TEST ON REAL ANDROID PHONE (20 minutes)

### 5.1 Enable Developer Mode
```
On your Android phone:
1. Go to Settings
2. About Phone
3. Tap "Build Number" 7 times
4. Back to Settings → Developer Options
5. Enable "USB Debugging"
6. Connect phone to computer with USB cable
7. Allow USB Debugging when prompted
```

### 5.2 Build to Phone
```
1. In Unity: File → Build Settings
2. Click "Build And Run"
3. Select location for APK
4. Verify your phone is connected
5. Unity will detect it automatically
6. Build will run directly on your phone!
```

---

## 🏗️ STEP 6: BUILD FINAL APK FOR RELEASE (15 minutes)

### 6.1 Create Release Build
```
1. In Unity: File → Build Settings
2. Switch from "Debug" to "Release"
3. Check "Create symbols.zip"
4. Click "Build"
5. Name file: "LawEmpire-v1.0.apk"
6. Save to: Desktop or Documents
7. Wait for build (5-10 minutes)
```

### 6.2 Test APK on Phone
```
1. Transfer APK to your phone via:
   - Email
   - Google Drive
   - Direct USB file transfer

2. Open file manager on phone
3. Tap APK file
4. Install (might show security warning - tap "Install Anyway")
5. Game should install and appear in apps!
```

---

## ✅ QUICK CHECKLIST

- [ ] Unity installed with Android Build Support
- [ ] Android Studio installed with SDK
- [ ] JDK 17 installed
- [ ] Android build platform selected in Unity
- [ ] Package name configured (com.simeonpangu.lawempire)
- [ ] LoginScene and GameScene created
- [ ] GameManager and UIManager scripts created
- [ ] Scripts connected to UI buttons
- [ ] Android emulator created
- [ ] Test build successful on emulator
- [ ] Test build successful on real phone
- [ ] Release APK created

---

## 🐛 TROUBLESHOOTING

### Problem: "Android SDK not found"
**Solution:**
- Go to Edit → Preferences → External Tools
- Set correct Android SDK path (from Android Studio)
- Restart Unity

### Problem: "Build fails with Gradle error"
**Solution:**
- Delete: Folder `Assets/Plugins/Android` (if exists)
- Go to File → Build Settings → Clear All
- Rebuild

### Problem: "App crashes on startup"
**Solution:**
- Check logcat (Android Studio → Logcat)
- Look for error messages
- Check internet connection is available
- Verify all scripts are correctly attached

### Problem: "Phone not detected"
**Solution:**
- Reinstall Android USB drivers
- Enable USB Debugging again
- Try different USB cable
- Restart phone and computer

---

## 📊 FILE SIZE EXPECTATIONS

- Basic demo APK: 50-100 MB
- Full game APK: 200-500 MB
- With all graphics: 500-1000 MB

💡 **Tip:** Compress textures to reduce size

---

## 🎯 NEXT STEPS AFTER TESTING

1. ✅ Add Firebase authentication
2. ✅ Add case system
3. ✅ Add courtroom mechanics
4. ✅ Add more UI screens
5. ✅ Add sound/music
6. ✅ Optimize for performance
7. ✅ Publish to Google Play Store

---

## 💬 NEED HELP?

**Common Resources:**
- Unity Android docs: https://docs.unity3d.com/Manual/android.html
- Android Studio docs: https://developer.android.com/docs
- Stack Overflow tag: `unity` + `android`
- r/Unity3D subreddit: https://reddit.com/r/Unity3D

---

**Status:** Ready to build! 🚀