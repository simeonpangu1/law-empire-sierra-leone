# 🔗 HOW TO ADD DEMO DOWNLOAD LINKS - COMPLETE GUIDE

## 📌 THREE WAYS TO HOST YOUR DEMO

---

## ✅ OPTION 1: GITHUB RELEASES (EASIEST - RECOMMENDED)

### Step 1: Build Your APK File
```
(See: BUILD_APK_GUIDE.md for how to build)
File created: LawEmpire-Demo-v0.1.apk (120 MB)
```

### Step 2: Create GitHub Release

```
1. Go to your repository:
   https://github.com/simeonpangu1/law-empire-sierra-leone

2. Click "Releases" tab (right side of repo)

3. Click "Create a new release" or "Draft a new release"

4. Fill in form:
   - Tag version: v0.1-demo
   - Release title: "Law Empire Demo v0.1 - Alpha Release"
   - Description:
     """
     🎮 Law Empire: Sierra Leone - Demo v0.1 Alpha
     
     ✅ What's Included:
     - Full character creation
     - 3 legal cases
     - Basic courtroom system
     - Coin earning
     - Experience system
     
     ⚙️ System Requirements:
     - Android 7.0+
     - 2GB RAM minimum
     - 150MB storage space
     
     🔗 Installation Guide: See INSTALL_ANDROID_DEMO.md
     """

5. Scroll down to "Attach binaries"

6. Click "Attach binaries by dropping them here"

7. Select your APK file:
   LawEmpire-Demo-v0.1.apk

8. Click "Publish release"
```

### Step 3: Get Your Download Link

```
After publishing, GitHub creates download URL:
https://github.com/simeonpangu1/law-empire-sierra-leone/releases/download/v0.1-demo/LawEmpire-Demo-v0.1.apk

Use this link in your documentation!
```

### Step 4: Update Your README

**Add to README.md:**
```markdown
## 📱 DOWNLOAD DEMO

[⬇️ Download Android APK v0.1](https://github.com/simeonpangu1/law-empire-sierra-leone/releases/download/v0.1-demo/LawEmpire-Demo-v0.1.apk)

**Requirements:** Android 7.0+, 150MB storage
**Installation:** See [INSTALL_ANDROID_DEMO.md](./INSTALL_ANDROID_DEMO.md)
```

**Advantages:**
- ✅ Free hosting (GitHub provides storage)
- ✅ Automatic download tracking
- ✅ Version control
- ✅ Release notes
- ✅ Easy updates

---

## ✅ OPTION 2: ITCH.IO (BEST FOR INDIE GAMES)

### Step 1: Create Itch.io Account

```
1. Go to: https://itch.io/
2. Click "Register" (top right)
3. Sign up with email or GitHub
4. Verify email
```

### Step 2: Create New Project

```
1. Click your profile (top right) → "Creator Dashboard"
2. Click "Create new project"
3. Fill in:
   - Project URL: law-empire-sierra-leone
   - Project title: Law Empire: Sierra Leone
   - Description: "A legal career simulation game based on Sierra Leone law"
   - Classification: Games
   - Kind of project: HTML5 Game / Android Game
   - Visibility: Public
   
4. Click "Create project"
```

### Step 3: Upload Your APK

```
1. In project settings, scroll to "Uploads"
2. Click "Upload files"
3. Select: LawEmpire-Demo-v0.1.apk
4. Click "Upload"
5. Set as "Android" platform
6. Set version: 0.1 (alpha)
7. Click "Publish"
```

### Step 4: Get Your Itch.io Link

```
Your game page URL:
https://simeonpangu.itch.io/law-empire-sierra-leone

Download link for APK:
https://simeonpangu.itch.io/law-empire-sierra-leone/download/[file-id]
```

**Advantages:**
- ✅ Free hosting
- ✅ Indie game community
- ✅ Built-in ratings/reviews
- ✅ Later: Add to Itch.io client for easy installation
- ✅ Analytics dashboard
- ✅ Can monetize later

---

## ✅ OPTION 3: GOOGLE DRIVE (QUICK & EASY)

### Step 1: Upload to Google Drive

```
1. Go to: https://drive.google.com
2. Click "New" �� "File upload"
3. Select: LawEmpire-Demo-v0.1.apk
4. Wait for upload
```

### Step 2: Make Shareable

```
1. Right-click file
2. Click "Share"
3. Change to "Anyone with link"
4. Copy link
```

### Step 3: Create Short Download Link

```
Original link (very long):
https://drive.google.com/file/d/1a2b3c4d5e6f7g8h9i0j/view?usp=sharing

Shorten it with:
- bit.ly
- tinyurl.com
- Google's link shortener

Result:
https://bit.ly/lawempire-demo
```

**Advantages:**
- ✅ Fastest to set up
- ✅ Free
- ✅ Reliable downloads
- ✅ Easy to update

**Disadvantages:**
- ❌ No version control
- ❌ Limited to 15GB free space
- ❌ No analytics

---

## ✅ OPTION 4: AWS S3 (PROFESSIONAL)

### Step 1: Create AWS Account

```
1. Go to: https://aws.amazon.com
2. Click "Create AWS Account"
3. Set up billing
```

### Step 2: Create S3 Bucket

```
1. Go to S3 service
2. Click "Create bucket"
3. Name: law-empire-demo
4. Region: us-east-1 (or your region)
5. Create
```

### Step 3: Upload APK

```
1. Open bucket
2. Click "Upload"
3. Select: LawEmpire-Demo-v0.1.apk
4. Click "Upload"
```

### Step 4: Make Public & Get Link

```
1. Right-click file
2. "Make public"
3. Copy Object URL:
   https://law-empire-demo.s3.amazonaws.com/LawEmpire-Demo-v0.1.apk
```

**Advantages:**
- ✅ Professional setup
- ✅ Scalable
- ✅ CDN integration
- ✅ Analytics
- ✅ Reliable

**Disadvantages:**
- ❌ Costs money (~$0.50/month for small files)
- ❌ More complex setup

---

## 📊 COMPARISON TABLE

| Method | Cost | Setup Time | Best For |
|--------|------|-----------|----------|
| **GitHub Releases** | Free | 5 min | Open source, updates |
| **Itch.io** | Free | 10 min | Indie games, community |
| **Google Drive** | Free | 2 min | Quick testing |
| **AWS S3** | $0.50+/mo | 30 min | Professional, scale |

---

## 🎯 RECOMMENDED: GITHUB + ITCH.IO

### Why Both?

1. **GitHub Releases**
   - Primary source for developers
   - Version tracking
   - Easy updates
   - Automatic backups

2. **Itch.io**
   - Reach game community
   - Player reviews/ratings
   - Analytics
   - Easy installation

### Setup Instructions:

```
1. Build your APK
2. Upload to GitHub Releases
3. Get GitHub download link
4. Also upload to Itch.io
5. Put both links in README
6. Players can choose preferred source
```

---

## 📝 UPDATE YOUR DOCUMENTATION

### Edit DEMO_DOWNLOAD.md:

```markdown
## 📱 OFFICIAL DEMO DOWNLOADS (v0.1 Alpha)

| Platform | Download | Size |
|----------|----------|------|
| **Android APK** | [GitHub](https://github.com/simeonpangu1/law-empire-sierra-leone/releases/download/v0.1-demo/LawEmpire-Demo-v0.1.apk) \| [Itch.io](https://simeonpangu.itch.io/law-empire-sierra-leone) | 120 MB |
| **Web Version** | [Play Online](https://law-empire-demo.itch.io) | N/A |
```

### Edit README.md:

Add to top of file:
```markdown
## 🚀 QUICK PLAY

**[⬇️ Download Android Demo](https://github.com/simeonpangu1/law-empire-sierra-leone/releases)**

**[🎮 Play on Itch.io](https://simeonpangu.itch.io/law-empire-sierra-leone)**

**[🌐 Coming Soon: Web Version](https://law-empire-demo.itch.io)**
```

---

## ✅ STEP-BY-STEP GITHUB RELEASE PROCESS

### Complete Walkthrough:

```
1. Go to: https://github.com/simeonpangu1/law-empire-sierra-leone

2. Click "Releases" tab

3. Click "Create a new release"
   (or "Draft a new release")

4. Fill Form:
   Tag version: v0.1-demo
   Release title: Law Empire Demo v0.1
   
   Description:
   """
   🎮 Demo v0.1 - Alpha Release
   
   ✅ Features:
   - Character creation
   - 3 legal cases
   - Courtroom system
   - Coin earning
   
   📥 Installation: See INSTALL_ANDROID_DEMO.md
   
   ⚙️ Requirements: Android 7.0+
   """

5. Scroll to "Attach binaries"

6. Drop or select: LawEmpire-Demo-v0.1.apk

7. Click "Publish release"

8. GitHub shows download URL automatically!

9. Copy URL and update your docs
```

---

## 🔗 FINAL DOWNLOAD LINK FORMAT

**For your documentation, use:**

```markdown
[⬇️ Download Android Demo v0.1](https://github.com/simeonpangu1/law-empire-sierra-leone/releases/download/v0.1-demo/LawEmpire-Demo-v0.1.apk)
```

**Or on Itch.io:**

```markdown
[🎮 Play on Itch.io](https://simeonpangu.itch.io/law-empire-sierra-leone)
```

---

## 📞 SHARE YOUR DEMO LINK

Once you have your link, share it:

- ✅ Update README.md
- ✅ Update DEMO_DOWNLOAD.md
- ✅ Post on Reddit (r/gamedev, r/unity3d)
- ✅ Share on Twitter/X
- ✅ Post on Discord servers
- ✅ Send to friends/family
- ✅ Add to portfolio

---

## 🎯 NEXT STEPS

1. ✅ Build APK (see BUILD_APK_GUIDE.md)
2. ✅ Create GitHub Release
3. ✅ Get download link
4. ✅ (Optional) Upload to Itch.io
5. ✅ Update all documentation
6. ✅ Test links work
7. ✅ Share with world!

---

**Status:** Ready to Host Your Demo 🚀