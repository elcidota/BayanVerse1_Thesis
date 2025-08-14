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
   ```

2. **Open in Unity**
   - Launch Unity Hub
   - Click "Open" and select the project folder
   - Wait for Unity to import all assets and packages

3. **Install Vuforia Engine**
   - In Unity, go to Window > Package Manager
   - Search for "Vuforia Engine" and install it
   - Restart Unity if prompted

## 📁 Project Structure

```
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
│   └── Lapu2 Animation Script.cs # Lapu-Lapu character animations
└── StreamingAssets/
    └── Vuforia/                  # AR target files
```

## 🎯 Key Features

### Characters
- **José Rizal**: Educational content and animations
- **Lapu-Lapu**: Warrior character with combat animations

### Scenes
- **Main Menu**: Game entry point with navigation
- **Gameplay**: Main interactive experience

### AR Features
- Image targets for Vuforia integration
- Cylinder targets for 3D object recognition
- Multi-target configurations

## 👥 Collaboration Guide

### For Teammates

1. **Initial Setup**
   ```bash
   git clone https://github.com/elcidota/thesisgame.git
   cd thesisgame
   ```

2. **Daily Workflow**
   ```bash
   # Pull latest changes
   git pull origin main
   
   # Make your changes in Unity
   
   # Commit and push your work
   git add .
   git commit -m "Description of your changes"
   git push origin main
   ```

3. **Creating New Features**
   - Create a new branch for major features
   ```bash
   git checkout -b feature/your-feature-name
   # Make changes
   git push origin feature/your-feature-name
   # Create pull request on GitHub
   ```

### Best Practices
- **Commit frequently** with descriptive messages
- **Pull before starting work** each day
- **Test your changes** before committing
- **Use meaningful branch names** for features
- **Communicate** with teammates about major changes

## 🔧 Development Notes

### Unity Settings
- Target Platform: Android/iOS for mobile AR
- Graphics API: OpenGL ES 3.0 (Android), Metal (iOS)
- Scripting Backend: IL2CPP

### Vuforia Configuration
- Database: BayaniVerse_imageTarget
- Target types: Image, Cylinder, Multi
- License key: Configure in VuforiaConfiguration.asset

## 📱 Building for Mobile

1. **Android Build**
   - File > Build Settings
   - Select Android platform
   - Configure Player Settings
   - Build APK or AAB

2. **iOS Build**
   - Requires macOS and Xcode
   - Configure signing and capabilities
   - Build for device or simulator

## 🐛 Troubleshooting

### Common Issues
- **Vuforia targets not working**: Check camera permissions and lighting
- **Build errors**: Verify all packages are installed
- **Git conflicts**: Communicate with teammates before resolving

### Getting Help
- Check Unity Console for error messages
- Review Vuforia documentation
- Ask teammates for assistance

## 📄 License

This project is part of a thesis study. Please respect academic integrity and collaboration guidelines.

## 🤝 Contributing

1. Follow the collaboration guide above
2. Test your changes thoroughly
3. Communicate with the team
4. Keep commits focused and descriptive

---

**Happy coding! 🎮✨**

*For questions or support, contact your team members or refer to Unity and Vuforia documentation.*
