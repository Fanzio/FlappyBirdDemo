# Flappy Bird Demo

Flappy Bird is a **2D demo for PC**, developed with **Unity in C#**, based on the classic game. The player controls a bird and must fly through the gaps between obstacles, aiming for the highest possible score.

The game ends when the character collides with an obstacle.

## Features

- Mouse-controlled jumping.
- Character movement handled by Unity’s 2D physics.
- Character rotation based on vertical velocity.
- Obstacles spawn at regular intervals with random heights.
- Scrolling obstacles and ground.
- Score updated after passing each obstacle.
- Sound effects for scoring and collisions.
- Game-over screen with the option to restart.
- Browser-playable demo.

## Controls

- **Left mouse button**: make the character jump.

## Repository structure

```text
FlappyBirdDemo/
├── Assets/             Scenes, scripts, prefabs and game assets
│   ├── Scenes/         Project scenes
│   └── Scripts/        C# source code
├── Packages/           Unity dependency configuration
├── ProjectSettings/    Project settings
├── docs/               Web demo files
└── README.md
```

## Opening the project

Requires **Unity 2021.3.11f1**.

1. Clone the repository or download and extract the ZIP archive.
2. Add the project to Unity Hub by selecting the folder containing `Assets`, `Packages` and `ProjectSettings`.
3. Open the project with Unity 2021.3.11f1.
4. Wait for the assets to finish importing.
5. Open the scene `Assets/Scenes/SampleScene.unity`.
6. Press **Play** to start the game in the Editor.

## Game logic

Each click sets the character’s vertical velocity upwards. Gravity makes it fall between jumps, while its rotation follows its vertical velocity.

Obstacles spawn at regular intervals with a random vertical position. They move to the left and are removed when they pass the designated boundary. The ground scrolls in the same direction and returns to its starting position to repeat the movement.

Passing through the central gap of an obstacle awards one point and plays a sound effect.

When the character collides with an obstacle, jumping, obstacle spawning and scrolling are disabled. The game-over screen is then displayed. Restarting reloads the scene.

## Preview

[Play the demo in your browser](https://fanzio.github.io/FlappyBirdDemo/)
