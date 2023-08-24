using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PuntosIU : MonoBehaviour
{
    public int puntos;
        public TMP_Text Textpuntos;

    private void Update()
    {
        Textpuntos.text = "Por reciclar: " + puntos.ToString();
    }
}
