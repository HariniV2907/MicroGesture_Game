# 🐍 VR Snake Game Using Micro Gestures

## 📄 Project Overview

This project is a Virtual Reality (VR) adaptation of the classic Snake Game popularized on Nokia mobile phones. Instead of traditional keyboard controls, the game utilizes **micro-gesture-based interaction**, allowing players to control the snake through thumb movements in an immersive VR environment.

The objective is to collect red color sphere to increase the score while avoiding blue color capsule and collisions with the game boundaries. To enhance user engagement and feedback, custom audio effects are incorporated for positive actions, penalties, and game-over events.

---

## 🎯 Objective

The goal of the game is to:

* Control the snake using micro gestures in a VR environment.
* Collect red color sphere to increase the score.
* Avoid blue color capsule that decrease the score.
* Prevent collisions with walls to stay alive.
* Achieve the highest possible score before the game ends.

---

## 🎮 Gameplay Logic

### 🟩 Snake (Player)

* Represented by a **Green Cube**.
* Controlled through micro-gesture inputs.
* Moves continuously within the game arena.

### 🔴 Apple (Reward)

* Represented by a **Red Sphere**.
* Increases the player's score by **+5 points** when collected.
* Plays a positive feedback sound effect.

### 🔵 Poison (Penalty)

* Represented by a **Blue Capsule**.
* Decreases the player's score by **-2 points** when collected.
* Plays a negative feedback sound effect.

### 🟫 Boundary Wall

* Represented by **Brown Walls** surrounding the play area.
* Collision with a wall immediately ends the game.
* Triggers the game-over sound effect.

---

## 🔊 Audio Features

The game includes immersive audio feedback to improve player experience:

* **Positive Sound Effect** – Played when collecting an apple.
* **Negative Sound Effect** – Played when hitting a poison object.
* **Game Over Sound Effect** – Played when the snake collides with a wall.

These audio cues provide immediate feedback and enhance engagement within the VR environment.

---

## 🧠 Features

* VR-based gameplay experience.
* Micro-gesture-controlled navigation.
* Real-time score tracking.
* Positive and negative reward system.
* Interactive sound effects.
* Collision detection system.
* Game-over mechanics.
* Simple and intuitive gameplay inspired by the classic Snake Game.

---

## 🛠️ Technologies Used

* Unity Engine
* C#
* Virtual Reality (VR)
* Micro Gesture Controls
* Unity Audio System
* Unity Physics and Collision Detection

---

## 📂 Project Structure

```text
VR-Snake-Game/
│
├── Assets/
│   ├── Scripts/
│   ├── Audio/
│   ├── Prefabs/
│   ├── Materials/
│   └── Scenes/
│
├── ProjectSettings/
├── Packages/
└── README.md
```

---

## 🎯 Scoring System

| Object    | Action    | Score     |
| --------- | --------- | --------- |
| 🔴 Apple  | Collect   | +5        |
| 🔵 Poison | Collect   | -2        |
| 🟫 Wall   | Collision | Game Over |

---

## 🚀 Future Enhancements

* Snake body growth mechanism.
* Multiple difficulty levels.
* Leaderboard system.
* Power-ups and bonus items.
* Dynamic obstacle generation.
* Multiplayer VR mode.
* Advanced hand-tracking controls.
* Environmental themes and visual effects.

---

## 🏁 Conclusion

This project reimagines the nostalgic Nokia Snake Game within a Virtual Reality environment using micro-gesture interactions. By combining classic gameplay mechanics with immersive VR controls and audio feedback, the game provides an engaging and interactive experience while demonstrating the potential of gesture-based gaming in virtual environments.
