#  Gameify – Augmented Reality Showcase

Gameify is an interactive **Augmented Reality (AR)** application built with **Unity** and **Vuforia** that brings physical game media to life.

By scanning real-world objects such as game cases or flat surfaces, the app overlays **3D characters, cinematic trailers, wearable assets, and life-sized virtual interactions** directly into the user’s environment.

The project demonstrates how AR can merge **physical collectibles with digital experiences**, creating immersive and interactive showcases.

---

## Features

### Image Marker Tracking
- Recognizes physical game covers and printed media  
- Overlays high-fidelity 3D models and video trailers  
- Examples: *The Witcher 3*, *Cyberpunk 2077*
![Demo](Ground-Detection-Demo.gif)




### Dynamic UI System
- Custom-built main menu
- Mode-based navigation:
  - **View** – Preview models and content
  - **Equip** – Try AR wearables
  - **Meet** – Spawn life-sized characters

### AR Wearables & Occlusion
- Interactive armor, gauntlets, and props
- Realistic depth occlusion for proper real-world blending
- Improves immersion and visual realism

### Surface / Floor Detection
- Detects flat surfaces in the environment
- Spawns full-scale characters into the scene
- Examples: Master Chief, Jinx

---

## Tech Stack

| Component | Technology |
|-----------|------------|
| Engine | Unity 2022.x |
| AR Framework | Vuforia Engine 10.x |
| Language | C# |
| Asset Management | Git LFS |

---

## Repository Management

This project uses **Git Large File Storage (LFS)** to handle large binary assets efficiently.

Tracked assets include:
- Vuforia Engine packages (`.tgz`)
- High-poly 3D models (`.fbx`, `.obj`)
- High-resolution textures
- Video files

