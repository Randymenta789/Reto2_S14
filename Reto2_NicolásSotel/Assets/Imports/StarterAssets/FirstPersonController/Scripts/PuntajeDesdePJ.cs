using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntajeDesdePJ : MonoBehaviour
{
	int contador;
	public Rigidbody rb; 


	public void OnTriggerEnter(Collider other)
	{

		

			Destroy(other.gameObject);
			contador = contador + 1;
		



	}

    public void Awake()
    {
		rb = GetComponent<Rigidbody>();
		contador = 0; 
    }
}
