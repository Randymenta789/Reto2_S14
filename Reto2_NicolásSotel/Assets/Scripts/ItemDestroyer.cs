using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour
{
   
    public GameObject ObjPuntos; 

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == ("Player"))
        {
            ObjPuntos.GetComponent<PuntosIU>().puntos -= 1;
            Destroy(gameObject);
        }

    }
}
