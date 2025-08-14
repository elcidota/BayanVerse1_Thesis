# BayanVerse - Thesis Game Project

A Unity-based educational game featuring Filipino historical figures and AR (Augmented Reality) elements using Vuforia.

## 🎮 Project Overview

BayanVerse is an interactive educational game that brings Filipino history to life through:
- **Character Animations**: Featuring historical figures like José Rizal and Lapu-Lapu
- **AR Integration**: Vuforia-powered augmented reality experiences
- **Educational Content**: Interactive learning about Philippine history and culture

## 🚀 Getting Started

### Prerequisites
- Unity 2022.3 LTS or later
- Vuforia Engine package
- Git for version control

### Installation
1. **Clone the repository**
   ```bash
   git clone https://github.com/elcidota/thesisgame.git
   cd thesisgame
Open in Unity

Launch Unity Hub

Click "Open" and select the project folder

Wait for Unity to import all assets and packages

Install Vuforia Engine

In Unity, go to Window > Package Manager

Search for "Vuforia Engine" and install it

Restart Unity if prompted

📁 Project Structure
bash
Copy
Edit
Assets/
├── Art/
│   ├── Characters/
│   │   ├── Char1_Rizal/          # José Rizal character assets
│   │   └── Char2LapuLapu/        # Lapu-Lapu character assets
│   └── MainMenuBG.png            # Main menu background
├── Scenes/
│   ├── MainMenu.unity            # Main menu scene
│   └── Gameplay.unity            # Main gameplay scene
├── Scripts/
│   ├── MainMenuManager.cs        # Main menu functionality
│   ├── RizalAnimationScript.cs   # Rizal character animations
│   └── Lapu2AnimationScript.cs   # Lapu-Lapu character animations
└── StreamingAssets/
    └── Vuforia/                  # AR target files
🎯 Key Features
Characters
José Rizal: Educational content and animations

Lapu-Lapu: Warrior character with combat animations

Scenes
Main Menu: Game entry point with navigation

Gameplay: Main interactive experience

AR Features
Image targets for Vuforia integration

Cylinder targets for 3D object recognition

Multi-target configurations

👥 Collaboration Guide
For Teammates
Initial Setup

bash
Copy
Edit
git clone https://github.com/elcidota/thesisgame.git
cd thesisgame
Daily Workflow

bash
Copy
Edit
# Pull latest changes
git pull origin main

# Make your changes in Unity

# Commit and push your work
git add .
git commit -m "Description of your changes"
git push origin main
Creating New Features

Create a new branch for major features

bash
Copy
Edit
git checkout -b feature/your-feature-name
# Make changes
git push origin feature/your-feature-name
# Create pull request on GitHub