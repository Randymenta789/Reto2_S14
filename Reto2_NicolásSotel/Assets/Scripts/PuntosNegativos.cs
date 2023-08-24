using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PuntosNegativos : MonoBehaviour
{
    public int puntos;
    public TMP_Text TextpuntosN;

    private void Update()
    {
        TextpuntosN.text = "Por eliminar: " + puntos.ToString();
    }
}
