using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CambioItem2 : MonoBehaviour, IAction
{
    private bool activated;
    public GameObject objetoPrefab; // Asigna el prefab en el Inspector

    public Vector3 posicionObjetoActual;

    void Start()
    {
        // Obtiene la posición del objeto actual
        posicionObjetoActual = transform.position;

        // Instancia el prefab en la misma posición del objeto actual

    }
    public void Activate()
    {
        activated = !activated;
        if (activated)
        {
            // Instancia el prefab al inicio del juego o en respuesta a algún evento
            Instantiate(objetoPrefab, posicionObjetoActual, Quaternion.identity);
            Destroy(this.gameObject);
        }

    }
}
