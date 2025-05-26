using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deteccionDeColisiones : MonoBehaviour
{
    public scoreManager scoreManager;

    void Start()
    {
        scoreManager = FindObjectOfType<scoreManager>();
    }
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Contacto");
        if (col.gameObject.name == "Player")
        {
            Destroy(gameObject);
            scoreManager.AddScore();
        }
    }

}
