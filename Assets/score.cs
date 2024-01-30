using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    public TMP_Text ScoreUI;



    // Start is called before the first frame update
    public void UpdateScore (int currentScore)
    {
        if (ScoreUI == null)
        {
            return;
        }
        ScoreUI.text = currentScore.ToString();
    }

    
}
