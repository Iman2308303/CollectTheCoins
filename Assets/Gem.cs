using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    public delegate void OnGemCollected(int amount);
    public static OnGemCollected onGemCollected;

    public int ScoreAmount = 10;
    private Collider2D _collider2D;

    public GameObject SoundFXPrefab;
    public GameObject ParticleSystemPrefab;
    // Start is called before the first frame update


    void Start()
    {
        _collider2D = GetComponent<Collider2D>();
    }


    void OnMouseOver()
    {
        ScoreManager scoreManager = GameObject.FindObjectOfType<ScoreManager>();

        if (SoundFXPrefab != null)
        {
            Instantiate(SoundFXPrefab, transform.position, Quaternion.identity);
        }

        // Instantiate particle effect prefab
        if (ParticleSystemPrefab != null)
        {
            Instantiate(ParticleSystemPrefab, transform.position, Quaternion.identity);
        }

        // Ensure ScoreManager is found
        if (scoreManager != null)
        {
            // Call GemCollected method of ScoreManager when gem is collected
            scoreManager.GemCollected(ScoreAmount);
        }
        else
        {
            Debug.LogError("ScoreManager not found in the scene.");
        }


        Destroy(gameObject);
    }
}
