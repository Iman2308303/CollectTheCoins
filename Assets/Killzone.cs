using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killzone : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D collider2D)
    {
        GameObject.Destroy(collider2D.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
