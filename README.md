# Maskman Run

**Maskman Run** is a 2D platformer game developed in **Unity using C#** as my **6th Semester Game Development project at HITEC University Taxila**.

The game features a complete multi-scene experience with a Main Menu, three progressively challenging levels, and an End Screen. Players navigate platforming challenges, avoid hazards, collect fruit for score, and reach trophies to progress through each level.

## Features

- 2D platformer gameplay
- Main Menu with Play and Quit options
- Three playable levels with increasing difficulty
- Player movement and jumping using 2D physics
- Moving and timed platforms
- Spike hazards
- Rotating saw blade hazards
- Fruit collectible and scoring system
- Player death and respawn system
- Trophy-based level progression
- Camera follow system
- Persistent score counter
- End / Congratulations screen
- Multi-scene game flow

## Technologies Used

- Unity
- C#
- Unity 2D
- Rigidbody2D Physics
- Unity Animator
- Unity Canvas UI
- SceneManager
- Visual Studio
- Pixel Adventure Asset Pack

## Game Structure

The game contains five main scenes:

1. **Main Menu**  
   Provides Play and Quit options and introduces the game's visual style.

2. **Level 1**  
   Introduces the core mechanics, moving platforms, fruit collectibles, spikes, and saw hazards.

3. **Level 2**  
   Increases the difficulty with denser hazards, additional moving platforms, and more challenging platforming.

4. **Level 3**  
   The final and most difficult level, combining multiple hazard types, moving platforms, collectibles, and a persistent score counter.

5. **End Screen**  
   Displays a congratulations message after the player successfully completes all three levels.

## Core Systems

### Player Movement

Player movement and jumping are implemented using Unity's `Rigidbody2D` physics system.

### Hazard System

The game includes:

- Ground spikes
- Ceiling spikes
- Rotating saw blades
- Environmental obstacles

Hazard collisions trigger the player's death and respawn logic.

### Collectible System

Fruit items are placed throughout the levels. Collecting fruit increases the player's score and removes the collected item from the scene.

### Level Progression

Each gameplay level contains a trophy at the end. Reaching the trophy loads the next scene using Unity's scene management system.

### UI and HUD

The game includes:

- Main Menu UI
- Play and Quit buttons
- Fruit score counter
- End Screen
- Gameplay HUD elements

## Project Structure

```text
Maskman-Run/
├── Assets/
├── Packages/
├── ProjectSettings/
├── .gitignore
└── README.md
```

## How to Run

Clone the repository:

```bash
git clone https://github.com/zainakhan-1/Maskman-Run.git
```

Navigate to the project directory:

```bash
cd Maskman-Run
```

Then:

1. Open **Unity Hub**
2. Choose **Add / Open Project**
3. Select the cloned `Maskman-Run` folder
4. Allow Unity to import the project files
5. Open the Main Menu scene
6. Press **Play**

## Gameplay

The player controls a masked character and must navigate through three levels while:

- Jumping between platforms
- Avoiding spikes and rotating saws
- Collecting fruit
- Timing jumps across moving platforms
- Reaching the trophy at the end of each level

Each level introduces a different visual theme and progressively more difficult platforming challenges.

## Future Improvements

Possible future improvements include:

- Pause menu and settings
- Volume and control settings
- Final score display
- Level selection
- Retry options
- Additional enemy types
- Checkpoint system
- Save and progression system

## Academic Project

This project was developed as part of my **6th Semester Game Development coursework** in the **BS Computer Science program at HITEC University Taxila**.

## Author

**Zain Ahmad Khan**

- LinkedIn: https://www.linkedin.com/in/zain-ahmad-khan-8689302a6
- Portfolio: https://zain-ahmad-khan-portfolio.vercel.app

---

Built as a Unity game development project demonstrating 2D platforming, physics, scene management, UI, collectibles, hazards, and level progression.
