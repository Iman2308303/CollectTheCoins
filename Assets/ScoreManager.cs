using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScoreManager : MonoBehaviour
{
    public delegate void OnScoreUpdate(int score);
    public static OnScoreUpdate OnScore;

    public delegate void OnFinalScore(int score);
    public static OnFinalScore OnFinal;

    public int totalScore = 200;
    public int CurrentScore = 0;
    public score _ScoreGUI;

    // Update the score when a gem is collected
    public void GemCollected(int Amount)
    {
        if (_ScoreGUI == null)
        {
            Debug.LogWarning("Missing Score GUI reference in ScoreManager.");
            return;
        }

        // If the current score has not reached the total score limit
        if (CurrentScore < totalScore)
        {
            // Increase the current score by the collected amount
            CurrentScore += Amount;

            // If the current score exceeds the total score limit, cap it
            if (CurrentScore >= totalScore)
            {
                CurrentScore = totalScore;

                // Invoke the OnFinal event to signal that the final score has been reached
                OnFinal?.Invoke(CurrentScore);
            }

            // Update the score UI
            _ScoreGUI.UpdateScore(CurrentScore);
            Debug.Log("Current Score: " + CurrentScore);

            // Invoke the OnScore event with the updated score
            OnScore?.Invoke(CurrentScore);
        }
    }
}