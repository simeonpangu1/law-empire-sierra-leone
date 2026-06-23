// Law Empire: Sierra Leone - Backend Server
// Node.js + Express + Firebase

const express = require('express');
const cors = require('cors');
const bodyParser = require('body-parser');
const { db, auth, firestore } = require('./firebase-config');

const app = express();
const PORT = process.env.PORT || 5000;

// Middleware
app.use(cors());
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: true }));

// =====================
// AUTHENTICATION ROUTES
// =====================

// Register new user
app.post('/api/auth/register', async (req, res) => {
  try {
    const { email, password, username, country } = req.body;

    // Create Firebase Auth user
    const userRecord = await auth.createUser({
      email: email,
      password: password,
      displayName: username
    });

    // Store additional user data in Firestore
    await firestore.collection('users').doc(userRecord.uid).set({
      username: username,
      email: email,
      country: country,
      level: 1,
      coins: 500,
      experience: 0,
      reputation: 0,
      careerPath: 'Student',
      createdAt: new Date(),
      lastLogin: new Date()
    });

    res.json({
      success: true,
      message: 'User registered successfully',
      uid: userRecord.uid
    });
  } catch (error) {
    res.status(400).json({
      success: false,
      error: error.message
    });
  }
});

// Login user
app.post('/api/auth/login', async (req, res) => {
  try {
    const { email, password } = req.body;

    // Firebase handles auth, we just verify
    const customToken = await auth.createCustomToken(email);

    res.json({
      success: true,
      message: 'Login successful',
      token: customToken
    });
  } catch (error) {
    res.status(401).json({
      success: false,
      error: 'Invalid credentials'
    });
  }
});

// =====================
// PLAYER ROUTES
// =====================

// Get player data
app.get('/api/player/:userId', async (req, res) => {
  try {
    const playerDoc = await firestore.collection('users').doc(req.params.userId).get();
    
    if (!playerDoc.exists) {
      return res.status(404).json({ error: 'Player not found' });
    }

    res.json({
      success: true,
      data: playerDoc.data()
    });
  } catch (error) {
    res.status(500).json({ error: error.message });
  }
});

// Update player coins
app.post('/api/player/:userId/coins', async (req, res) => {
  try {
    const { amount } = req.body;
    
    await firestore.collection('users').doc(req.params.userId).update({
      coins: admin.firestore.FieldValue.increment(amount)
    });

    res.json({
      success: true,
      message: `Added ${amount} coins`
    });
  } catch (error) {
    res.status(500).json({ error: error.message });
  }
});

// Level up player
app.post('/api/player/:userId/levelup', async (req, res) => {
  try {
    await firestore.collection('users').doc(req.params.userId).update({
      level: admin.firestore.FieldValue.increment(1)
    });

    res.json({
      success: true,
      message: 'Level increased'
    });
  } catch (error) {
    res.status(500).json({ error: error.message });
  }
});

// =====================
// CASES ROUTES
// =====================

// Get all cases
app.get('/api/cases', async (req, res) => {
  try {
    const casesSnapshot = await firestore.collection('cases').get();
    const cases = [];
    
    casesSnapshot.forEach(doc => {
      cases.push({ id: doc.id, ...doc.data() });
    });

    res.json({
      success: true,
      data: cases
    });
  } catch (error) {
    res.status(500).json({ error: error.message });
  }
});

// Get case by ID
app.get('/api/cases/:caseId', async (req, res) => {
  try {
    const caseDoc = await firestore.collection('cases').doc(req.params.caseId).get();
    
    if (!caseDoc.exists) {
      return res.status(404).json({ error: 'Case not found' });
    }

    res.json({
      success: true,
      data: caseDoc.data()
    });
  } catch (error) {
    res.status(500).json({ error: error.message });
  }
});

// Submit case verdict
app.post('/api/cases/:caseId/verdict', async (req, res) => {
  try {
    const { userId, verdict } = req.body;
    
    // Store verdict in Firestore
    await firestore.collection('cases').doc(req.params.caseId).collection('verdicts').add({
      userId: userId,
      verdict: verdict,
      timestamp: new Date()
    });

    res.json({
      success: true,
      message: 'Verdict submitted',
      reward: 1000
    });
  } catch (error) {
    res.status(500).json({ error: error.message });
  }
});

// =====================
// LEADERBOARD ROUTES
// =====================

// Get global leaderboard
app.get('/api/leaderboard', async (req, res) => {
  try {
    const leaderboardSnapshot = await firestore.collection('users')
      .orderBy('coins', 'desc')
      .limit(100)
      .get();

    const leaderboard = [];
    leaderboardSnapshot.forEach(doc => {
      leaderboard.push({
        rank: leaderboard.length + 1,
        username: doc.data().username,
        coins: doc.data().coins,
        level: doc.data().level
      });
    });

    res.json({
      success: true,
      data: leaderboard
    });
  } catch (error) {
    res.status(500).json({ error: error.message });
  }
});

// =====================
// HEALTH CHECK
// =====================

app.get('/api/health', (req, res) => {
  res.json({
    status: 'Backend server is running',
    timestamp: new Date()
  });
});

// =====================
// ERROR HANDLING
// =====================

app.use((err, req, res, next) => {
  console.error(err.stack);
  res.status(500).json({
    error: 'Internal server error',
    message: err.message
  });
});

// =====================
// START SERVER
// =====================

app.listen(PORT, () => {
  console.log(`
╔════════════════════════════════════════╗
║ Law Empire: Sierra Leone Backend      ║
║ Server running on port ${PORT}           ║
║ Status: Ready for connections          ║
╚════════════════════════════════════════╝
  `);
});

module.exports = app;