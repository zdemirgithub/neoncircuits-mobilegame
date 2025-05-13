# ⚡ Neon Circuits

A 2D neon-themed puzzle game for Android where you rotate circuit tiles to connect all power sources and terminals. Online leaderboards track your fastest solves.

---

## 🚀 Features

- 🧠 Puzzle gameplay with rotating tiles
- 🔄 Pipe/circuit logic mechanic (not color-based)
- ✨ Neon glow visual theme
- 📶 Online leaderboard support (Firebase or PlayFab ready)
- 📱 Android optimized

---

## 🎮 How to Play

- Tap tiles to rotate
- Connect all terminals to the source
- Beat levels fast and climb the global leaderboard

---

## 📦 Installation

1. Clone the repo and open in Unity 2022+
2. Run `Scenes/Main.unity`
3. Build for Android under **File > Build Settings**

---

## 🌐 Leaderboard Setup

### Firebase (optional)

1. Set up Firebase project: [https://console.firebase.google.com](https://console.firebase.google.com)
2. Enable **Authentication** and **Firestore**
3. Use `Firebase Unity SDK`
4. Integrate inside `OnlineManager.cs` like so:

```csharp
FirebaseFirestore db = FirebaseFirestore.DefaultInstance;
DocumentReference docRef = db.Collection("leaderboards").Document(levelID);
await docRef.SetAsync(new { time = time });
Or use PlayFab if preferred.

📁 Folder Structure
Assets/Scripts/ — Game logic and managers

Assets/Prefabs/ — Circuit tile prefabs

Assets/ScriptableObjects/Levels/ — Level configuration

Assets/Materials/ — Neon visual assets

Assets/Scenes/ — Main game scene

📱 Platform
✅ Android

🔲 iOS (can be added)

✅ Unity Editor

🧑‍💻 Author
Built with Unity + love.
Assets and mechanics are modular for easy expansion.
