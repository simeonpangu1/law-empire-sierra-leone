// Firebase Configuration for Law Empire: Sierra Leone
// Initialize Firebase for backend services

const admin = require('firebase-admin');

// Download service account key from Firebase Console
// Project Settings → Service Accounts → Generate New Private Key
const serviceAccount = require('./serviceAccountKey.json');

admin.initializeApp({
  credential: admin.credential.cert(serviceAccount),
  databaseURL: "https://law-empire-sierra-leone.firebaseio.com"
});

const db = admin.database();
const auth = admin.auth();
const firestore = admin.firestore();

module.exports = {
  admin,
  db,
  auth,
  firestore
};