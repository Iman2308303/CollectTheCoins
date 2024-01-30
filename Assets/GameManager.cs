using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public ScoreManager scoreManager;
    private bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        // Subscribe to the OnFinal event of the ScoreManager
        ScoreManager.OnFinal += HandleFinalScore;
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the game is over
        if (!isGameOver)
        {
            // Update game logic here
            // For example, move objects, handle player input, etc.
        }
    }

    // Method to handle final score event
    void HandleFinalScore(int score)
    {
        // Stop game logic when the final score is reached
        isGameOver = true;
        Debug.Log("Game Over. Final Score: " + score);

        // Return to the main menu
        ReturnToMainMenu();
    }

    // Method to return to the main menu
    void ReturnToMainMenu()
    {
        // Load the main menu scene
        SceneManager.LoadScene("Main menu");
    }
}