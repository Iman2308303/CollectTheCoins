using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuToStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        if (Input.anyKey)
        {
            SceneManager.LoadScene("MainGame");
        }
    }
}
