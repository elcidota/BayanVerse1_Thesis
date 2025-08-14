using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Add this for Button references
using System.Collections.Generic; // Add this for List

public class PauseMenuManager : MonoBehaviour
{
    public GameObject pauseMenuUI; // Reference to the Pause Menu UI
    
    [Header("Pause Menu Buttons")]
    public Button resumeButton; // Reference to the Resume button
    public Button mainMenuButton; // Reference to the Main Menu button
    public Button exitGameButton; // Reference to the Exit Game button

    private bool isPaused = false;
    private List<Button> allButtonsInScene = new List<Button>(); // Store all buttons found in scene
    private Dictionary<Button, bool> originalButtonStates = new Dictionary<Button, bool>(); // Store original button states

    void Start()
    {
        pauseMenuUI.SetActive(false); // Ensure the pause menu is initially hidden
        SetPauseMenuInteractable(false); // Ensure the pause menu is not interactable initially
        
        // Find all buttons in the scene automatically
        FindAllButtonsInScene();
    }

    void Update()
    {
        // Toggle pause menu when "Esc" is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                ShowPauseMenu();
            }
        }
    }

    // Automatically find all buttons in the scene
    private void FindAllButtonsInScene()
    {
        allButtonsInScene.Clear();
        originalButtonStates.Clear();
        Button[] buttons = FindObjectsOfType<Button>();
        
        foreach (Button button in buttons)
        {
            // Only add buttons that are NOT our 3 pause menu buttons
            if (button != resumeButton && button != mainMenuButton && button != exitGameButton)
            {
                allButtonsInScene.Add(button);
                // Store the original interactable state of each button
                originalButtonStates[button] = button.interactable;
            }
        }
        
        Debug.Log($"Found {allButtonsInScene.Count} buttons to manage during pause");
    }

    // Show the pause menu and make only the 3 buttons interactable
    public void ShowPauseMenu()
    {
        pauseMenuUI.SetActive(true); // Activate the Pause Menu
        Time.timeScale = 0f; // Pause the game
        isPaused = true;

        // Make only the 3 specific buttons clickable
        SetPauseMenuInteractable(true);
        
        // Disable all other buttons in the scene
        DisableAllOtherButtons();
    }

    // Resume the game and disable interaction with the pause menu
    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false); // Deactivate the Pause Menu
        Time.timeScale = 1f; // Resume the game
        isPaused = false;

        // Disable interaction with the pause menu
        SetPauseMenuInteractable(false);
        
        // Re-enable all other buttons to their original state
        RestoreAllButtonStates();
    }

    // Set only the 3 specific buttons interactable
    private void SetPauseMenuInteractable(bool interactable)
    {
        // Enable/Disable only the 3 specific buttons
        if (resumeButton != null)
            resumeButton.interactable = interactable;
        if (mainMenuButton != null)
            mainMenuButton.interactable = interactable;
        if (exitGameButton != null)
            exitGameButton.interactable = interactable;
    }

    // Disable all other buttons in the scene
    private void DisableAllOtherButtons()
    {
        int disabledCount = 0;
        
        foreach (Button button in allButtonsInScene)
        {
            if (button != null && button.gameObject.activeInHierarchy)
            {
                button.interactable = false;
                disabledCount++;
            }
        }
        
        Debug.Log($"Disabled {disabledCount} buttons during pause");
    }

    // Restore all buttons to their original state
    private void RestoreAllButtonStates()
    {
        int restoredCount = 0;
        
        foreach (Button button in allButtonsInScene)
        {
            if (button != null && button.gameObject.activeInHierarchy)
            {
                // Restore the button to its original interactable state
                if (originalButtonStates.ContainsKey(button))
                {
                    button.interactable = originalButtonStates[button];
                    restoredCount++;
                }
            }
        }
        
        Debug.Log($"Restored {restoredCount} buttons to their original state");
    }

    // Load Main Menu scene
    public void LoadMainMenu()
    {
        Time.timeScale = 1f; // Ensure the game is not paused when leaving
        SceneManager.LoadScene("MainMenu"); // Load Main Menu scene
    }

    // Exit game
    public void ExitGame()
    {
        Application.Quit(); // Close the application
    }
}
