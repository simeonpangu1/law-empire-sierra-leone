# 🏗️ BUILD APK GUIDE FOR DEVELOPERS

**How to build an APK file that can be installed on Android devices**

---

## 📋 PREREQUISITES

Make sure you have these installed:

```
✅ Unity 2022 LTS (with Android Build Support)
✅ Android Studio with SDK
✅ JDK 11 or higher
✅ Git
✅ Minimum 20 GB free disk space
```

---

## 🔧 STEP 1: CONFIGURE UNITY

### 1.1 Open Your Project
```
1. Launch Unity Hub
2. Open: law-empire-sierra-leone/frontend/unity
3. Wait for project to load (~5 minutes)
```

### 1.2 Configure Player Settings
```
1. File → Build Settings
2. Select "Android" platform
3. Click "Switch Platform" (wait 5-10 minutes)
4. Click "Player Settings"

5. In Inspector window:
   
   IDENTIFICATION:
   - Package Name: com.simeonpangu.lawempire
   - Version: 1.0
   - Bundle Version Code: 1
   
   API LEVELS:
   - Minimum API Level: 24 (Android 7.0)
   - Target API Level: 33 (Latest)
   
   GRAPHICS:
   - Graphics APIs: OpenGL ES 3
   - Multithreaded Rendering: ON
   
   ORIENTATION:
   - Default Orientation: Portrait
   - Allow Portrait: ON
   - Allow Landscape: ON
```

### 1.3 Configure Android Build System
```
1. Edit → Project Settings → Player
2. Android tab → Publishing Settings
3. Build System: "Gradle" (recommended)
4. Custom Gradle: OFF (use built-in)
5. Scripting Backend: IL2CPP (faster) or Mono
```

---

## 📦 STEP 2: BUILD THE APK

### Method A: Development APK (For Testing)

```
1. File → Build Settings
2. Scenes in Build:
   - Make sure LoginScene is first
   - Make sure GameScene is second

3. Click "Build" button
4. Choose folder: Desktop or Documents
5. Filename: "LawEmpire-Debug.apk"
6. Click "Build"
7. Wait 10-15 minutes
8. Done! APK is ready
```

### Method B: Release APK (For Distribution)

```
1. File → Build Settings
2. Switch from "Debug" to "Release" mode
3. Check "Create symbols.zip"
4. Scenes configured same as above
5. Click "Build"
6. Filename: "LawEmpire-Release-v0.1.apk"
7. Wait 15-20 minutes
8. APK file created successfully
```

### Method C: AAB (Android App Bundle - For Play Store)

```
1. File → Build Settings
2. Select "Android"
3. Check "Build App Bundle (Google Play)"
4. Click "Build"
5. Choose location & filename
6. Wait 20-25 minutes
7. Creates .aab file (smaller, optimized for Play Store)
```

---

## ✅ STEP 3: VERIFY BUILD

### Check APK File
```
1. Navigate to build location
2. Should see: LawEmpire-Debug.apk or LawEmpire-Release.apk
3. File size: 80-150 MB (normal)
4. If smaller: Missing assets
5. If larger: Includes debug symbols
```

### Verify APK Contents
```bash
# On Windows Command Prompt / Mac Terminal:
adb shell pm path com.simeonpangu.lawempire

# Should return path if APK is valid
```

---

## 📱 STEP 4: TEST ON DEVICE

### Option 1: Using Android Emulator (Fastest)

```
1. Android Studio → Device Manager
2. Create or start emulator
3. File → Build Settings → Build And Run
4. Select emulator from list
5. Unity auto-builds and runs
6. Test on emulator (5 min load time)
```

### Option 2: Using Real Android Phone

```
1. Connect phone via USB cable
2. Enable USB Debugging on phone
3. File → Build Settings → Build And Run
4. Select phone from list
5. Unity builds and installs
6. Game launches on phone automatically
```

### Option 3: Manual Installation

```bash
# Install APK via ADB:
adb install LawEmpire-Debug.apk

# Or uninstall first if already installed:
adb uninstall com.simeonpangu.lawempire
adb install LawEmpire-Debug.apk

# Launch:
adb shell am start -n com.simeonpangu.lawempire/.MainActivity
```

---

## 🚀 STEP 5: CREATE RELEASE BUILD

### Signing the APK (Required for Play Store)

```
1. File → Build Settings
2. Click "Player Settings"
3. Android → Publishing Settings
4. Check "Create New Keystore"
5. Fill in:
   - Keystore: lawempire.keystore
   - Alias: lawempire_key
   - Password: [Create strong password]
   - CN: Simeon Austin David Pangu

6. Build APK (will be automatically signed)
```

### Upload to Play Store

```
1. Go to: https://play.google.com/console
2. Create app
3. Upload AAB file (not APK)
4. Fill app details
5. Submit for review
6. Wait 24-48 hours for approval
```

---

## 🔍 TROUBLESHOOTING BUILD ISSUES

### "Android SDK not found"
```
Solution:
1. Edit → Preferences → External Tools
2. Set Android SDK path manually
3. Restart Unity
4. Try building again
```

### "Gradle build failed"
```
Solution:
1. Delete: Assets/Plugins/Android/
2. Delete: Temp/ folder
3. Close and reopen Unity
4. Try building again
```

### "Out of memory error"
```
Solution:
1. Close other applications
2. Increase Unity memory allocation
3. Edit → Preferences → Memory Settings
4. Increase to 16GB or more
5. Restart Unity
```

### "APK too large (>500MB)"
```
Solution:
1. Compress textures:
   - Assets → Right-click → Reimport
   - Set to "Compressed" format

2. Remove unused assets:
   - Assets → Clean Up
   - Delete unused folders

3. Disable unused features:
   - Player Settings → Graphics APIs
   - Remove OpenGL ES 2

4. Split into multiple APKs by density
```

### "Build hangs or freezes"
```
Solution:
1. Close all background apps
2. Increase swap space
3. Use SSD instead of HDD
4. Reduce target API level
5. Try without symbols
```

---

## 📊 BUILD OPTIMIZATION

### For Smaller File Size
```
1. Compression:
   Player Settings → Compression Format: LZ4

2. Scripting Backend: IL2CPP (best compression)

3. Graphics:
   - Use ASTC compression for textures
   - Remove unused shaders
   - Optimize animation clips

4. Audio:
   - MP3 format (smaller)
   - 128 kbps bitrate
```

### For Better Performance
```
1. Graphics:
   - Reduce shadow quality
   - Disable bloom effects on low-end devices
   - Use object pooling

2. Physics:
   - Disable unused colliders
   - Use simple collider shapes

3. Memory:
   - Profile in Unity Profiler
   - Remove memory leaks
   - Use object recycling
```

---

## 📋 BUILD CHECKLIST

- [ ] All scenes in Scene list
- [ ] No compilation errors
- [ ] Package name configured
- [ ] API levels set correctly
- [ ] Keystore signed
- [ ] Tested on emulator
- [ ] Tested on real device
- [ ] File size reasonable
- [ ] Performance acceptable
- [ ] No debug symbols in release
- [ ] Privacy policy link added
- [ ] Icons and splash screen set

---

## 📈 NEXT STEPS

1. ✅ Build successful APK
2. ✅ Test thoroughly
3. ✅ Create screenshots (5-8)
4. ✅ Write app description
5. ✅ Set up privacy policy
6. ✅ Submit to Google Play Store
7. ✅ Monitor reviews
8. ✅ Update regularly

---

**Build Guide Version:** 1.0  
**Last Updated:** June 23, 2026  
**Status:** Ready for Build ✅