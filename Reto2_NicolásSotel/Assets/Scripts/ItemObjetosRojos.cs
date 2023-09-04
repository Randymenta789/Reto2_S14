using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObjetosRojos : MonoBehaviour
{
    public GameObject ObjPuntosNegativos;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == ("Player"))
        {
            ObjPuntosNegativos.GetComponent<PuntosNegativos>().puntos -= 1;
            Destroy(gameObject); 
        }

    }
}
