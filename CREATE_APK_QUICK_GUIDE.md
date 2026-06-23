# 🎮 LAW EMPIRE: SIERRA LEONE - APK BUILD INSTRUCTIONS

## ⚡ FASTEST WAY TO BUILD YOUR FIRST APK (1-2 Hours)

### OPTION 1: Use Unity (Recommended for Beginners)

---

## 📋 PREREQUISITES CHECK

Before starting, verify you have:

```
✅ Unity 2022 LTS installed
✅ Android Build Support enabled
✅ Android Studio with SDK
✅ JDK 11+ installed
✅ 20 GB free disk space
✅ Internet connection
```

**Don't have these?** See `ANDROID_SETUP_GUIDE.md` to install them first.

---

## 🚀 STEP 1: DOWNLOAD AND OPEN PROJECT (10 minutes)

### 1.1 Clone Repository
```bash
git clone https://github.com/simeonpangu1/law-empire-sierra-leone.git
cd law-empire-sierra-leone
```

### 1.2 Open in Unity
```
1. Open Unity Hub
2. Click "Open Project"
3. Navigate to: law-empire-sierra-leone/frontend/unity
4. Click "Open"
5. Wait for import (5-10 minutes)
```

**You should see:**
- Project loads in Unity Editor
- Assets folder populated
- No red errors in Console

---

## ⚙️ STEP 2: CONFIGURE ANDROID BUILD SETTINGS (15 minutes)

### 2.1 Switch to Android Platform
```
1. Go to: File → Build Settings
2. In Platform list (left side), click "Android"
3. Click "Switch Platform" button
4. Wait 5-10 minutes (Unity compiles)
5. Android icon should appear checked
```

### 2.2 Configure Player Settings
```
1. In Build Settings window, click "Player Settings" (bottom)
2. Inspector panel opens on right

3. Under "Resolution and Presentation":
   - Default Orientation: Portrait
   - Portrait Left: ON
   - Portrait Right: ON
   - Landscape Left: ON
   - Landscape Right: ON

4. Under "Identification":
   - Package Name: com.simeonpangu.lawempire
   - Version: 1.0.0
   - Bundle Version Code: 1

5. Under "API Levels":
   - Minimum API Level: 24 (Android 7.0)
   - Target API Level: 33 or latest

6. Under "Graphics":
   - Graphics APIs: OpenGL ES 3
   - Multithreaded Rendering: ON
```

### 2.3 Add Scenes to Build
```
1. Still in Build Settings
2. Look for "Scenes in Build" section
3. Click "Add Open Scenes" button
4. Or manually drag scenes from Assets/Scenes folder

5. Order should be:
   - Scene 0: LoginScene
   - Scene 1: GameScene
   - Scene 2: MainMenuScene (if exists)
```

### 2.4 Set External Tools Paths
```
1. Edit → Preferences (or Unity → Preferences on Mac)
2. Go to "External Tools"
3. Set these paths:

   Android SDK Path:
   (Find where Android Studio installed SDK)
   Usually: C:\Users\[YourName]\AppData\Local\Android\sdk
   Or on Mac: ~/Library/Android/sdk
   
   Android NDK Path:
   Usually: same as SDK/ndk-bundle or ndk/[version]
   
   JDK Path:
   Usually: C:\Program Files\Java\jdk-11 (or your JDK version)

4. Click "Apply"
5. Close Preferences
```

---

## 🔨 STEP 3: BUILD THE APK (20-30 minutes)

### 3.1 Create Build Folder
```
1. In your computer file explorer
2. Create new folder: Desktop/Builds
3. Or: Documents/GameBuilds
```

### 3.2 Build APK in Unity
```
1. Back in Unity: File → Build Settings
2. Click "Build" button (bottom right)
3. File dialog opens
4. Navigate to folder you created
5. Filename: LawEmpire-Demo-v0.1.apk
6. Click "Save"

7. BUILD STARTS - DO NOT CLOSE UNITY!
   - Watch progress bar at bottom of Unity
   - May take 15-30 minutes
   - "Building player..." message shows

8. Completed message appears
9. APK file created in your folder!
```

---

## ✅ STEP 4: VERIFY APK WAS CREATED (2 minutes)

### 4.1 Check File Location
```
1. Open file explorer
2. Navigate to: Desktop/Builds (or your build folder)
3. Should see: LawEmpire-Demo-v0.1.apk
4. File size: 100-150 MB (normal)
```

### 4.2 Verify File Properties
```
- File size should be > 50 MB
- Created today
- File type: .apk
```

**If file is missing:**
- Check Unity Console for errors
- Verify all scenes are added
- Try rebuilding

---

## 📱 STEP 5: TEST ON ANDROID DEVICE (10 minutes)

### 5.1 Test on Emulator (Easiest)
```
1. Android Studio → Device Manager
2. Create or start Android Virtual Device (emulator)
3. Wait for emulator to boot
4. In Unity: File → Build Settings → Build And Run
5. Select emulator from list
6. Unity builds and auto-installs
7. Game launches on emulator
```

### 5.2 Test on Real Phone
```
1. Connect Android phone via USB cable
2. Enable USB Debugging on phone:
   Settings → Developer Options → USB Debugging → ON
   
3. Allow USB Debugging when prompted on phone
4. In Unity: File → Build Settings → Build And Run
5. Select phone from device list
6. Unity builds and installs
7. Game launches on your phone!
```

### 5.3 Manual Installation (If Build And Run doesn't work)
```bash
# Using command line:
adb install LawEmpire-Demo-v0.1.apk

# Or transfer APK to phone and tap to install
```

---

## 🎉 STEP 6: CREATE RELEASE APK FOR DISTRIBUTION (5 minutes)

### 6.1 Build Release Version
```
1. File → Build Settings
2. Change from "Debug" to "Release"
3. Check "Create symbols.zip"
4. Click "Build"
5. Filename: LawEmpire-Demo-v0.1-RELEASE.apk
6. Wait for build to complete
```

### 6.2 Sign APK (For Play Store)
```
This creates a signing certificate:

1. File → Build Settings → Player Settings
2. Android tab → Publishing Settings
3. Check "Create New Keystore"
4. Fill in:
   - Keystore: lawempire.keystore
   - Alias: lawempire_key
   - Password: [Create strong password - SAVE THIS!]
   - Confirm Password: [same]
   - CN: Simeon Austin David Pangu Esq.

5. Click "Create Key"
6. Build APK (now auto-signed)
```

---

## 🚨 TROUBLESHOOTING BUILD ERRORS

### Error: "Android SDK not found"
```
Solution:
1. Edit → Preferences → External Tools
2. Point to correct Android SDK location
3. Restart Unity
4. Try building again
```

### Error: "Build failed - Gradle error"
```
Solution:
1. Delete: Temp/ folder in project
2. Delete: Obj/ folder if exists
3. Close and reopen Unity
4. Try building again
```

### Error: "Out of memory during build"
```
Solution:
1. Close other applications
2. Edit → Preferences → Memory
3. Increase memory allocation
4. Try building again
```

### APK is too large (>500 MB)
```
Solution:
1. Compress textures in Assets
2. Remove unused assets
3. Use IL2CPP scripting backend (better compression)
4. Remove debug symbols: uncheck "Create symbols.zip"
```

### Build succeeds but app crashes on startup
```
Solution:
1. Check Unity Console for errors
2. Verify all scenes are included
3. Check that scripts compile without errors
4. Look at Android logcat:
   adb logcat | grep -i "law empire"
5. Fix errors and rebuild
```

---

## 📊 BUILD CHECKLIST

- [ ] Unity 2022 LTS installed
- [ ] Android Build Support enabled
- [ ] Project opens without errors
- [ ] Android platform selected in Build Settings
- [ ] Package name set to com.simeonpangu.lawempire
- [ ] All scenes added to build
- [ ] Android SDK path configured
- [ ] Build folder created
- [ ] APK built successfully
- [ ] APK file exists on disk
- [ ] APK tested on emulator or phone
- [ ] App launches without crashing
- [ ] Release APK created
- [ ] Ready to upload!

---

## 📍 YOUR APK FILE LOCATION

**Default location after build:**
```
Desktop/Builds/LawEmpire-Demo-v0.1.apk

Or wherever you chose to save
```

**Now that you have APK, next steps:**
1. ✅ Upload to GitHub Releases
2. ✅ Get download link
3. ✅ Share with world!

---

## 📚 NEXT: UPLOAD TO GITHUB RELEASES

See: `HOW_TO_ADD_DEMO_LINKS.md`

Quick summary:
```
1. Go to: https://github.com/simeonpangu1/law-empire-sierra-leone/releases
2. Click "Create new release"
3. Upload your APK file
4. Publish
5. GitHub gives you download link!
```

---

## ⏱️ TIME ESTIMATE

| Task | Time |
|------|------|
| Install/setup tools | 30-60 min (one-time) |
| Configure Unity | 10 min |
| Build APK | 20-30 min |
| Test | 10 min |
| Upload to GitHub | 5 min |
| **TOTAL** | **45 min - 2 hours** |

---

## 🆘 STILL STUCK?

1. Check Console tab in Unity for error messages
2. Read error carefully - it usually says what's wrong
3. Search error on Stack Overflow
4. Check BUILD_APK_GUIDE.md again
5. Post issue on GitHub: https://github.com/simeonpangu1/law-empire-sierra-leone/issues

---

## 🎯 SUCCESS = YOU HAVE:

✅ APK file on your computer
✅ App runs on Android device
✅ Ready to share with world
✅ Ready to upload to app stores

---

**Status:** Ready to Build! 🚀