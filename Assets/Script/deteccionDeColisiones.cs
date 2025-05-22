using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deteccionDeColisiones : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Contacto");
        if(col.gameObject.name == "Player")
        Destroy(gameObject);
    }
}
