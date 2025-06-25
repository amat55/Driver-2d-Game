# 🚗 Driver‑2D‑Game

A simple but fun 2D top‑down driving game built with **Unity** and **C#**, where you pick up and deliver packages across a colorful map. Inspired by common Unity learning resources :contentReference[oaicite:1]{index=1}.

---

## 🎯 Features

- **Package pickup & delivery**: Drive to pickups, collect packages, and deliver to designated destinations.  
- **Camera follow**: Smooth camera tracking that keeps the player in view.  
- **Collision & speed controls**: Slows down on impact, includes speed‑up pickups.  
- **Visual feedback**: Change car color upon package pickup.  
- **Basic 2D physics**: Simple collision detection and movement.

---

## 📦 Getting Started

### Prerequisites

- **Unity** (version ≥ 2021.3 recommended)  
- **Visual Studio**, **VS Code**, or Unity's built‑in editor

### Installation

```bash
git clone https://github.com/amat55/Driver-2d-Game.git
cd Driver-2d-Game


Running the Game
Open Unity Hub → "Add" → select the cloned folder

Launch the project in the Unity Editor

Open the Main scene (or appropriate level)

Hit the Play button and enjoy!

⌨️ Controls
Action	Keys
Move forward/back	W / S or ↑ / ↓
Turn left/right	A / D or ← / →

Assets/
  ├── Scripts/       # Driver, Delivery, Camera controllers
  ├── Scenes/        # Unity scene(s)
  ├── Sprites/       # Art assets (car, boxes, environment)
  ├── Prefabs/       # Reusable GameObjects (car, package)
  ├── Materials/     # Visual materials
  └── Audio/         # Sound effects (if any)
ProjectSettings/
.vscode/             # VS Code settings
Packages/            # Unity package dependencies


✨ Future Enhancements
Add UI elements: timers, package counter, score tracking

Integrate sound effects for collisions and pickups

Add levels, a mini‑map, or GPS guidance

Implement mobile controls, animations, and polish feedback

Add a menu UI and high score leaderboard