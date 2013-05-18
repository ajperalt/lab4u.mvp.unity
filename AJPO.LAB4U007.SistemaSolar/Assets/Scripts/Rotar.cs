using UnityEngine;
using System.Collections;

public class Rotar : MonoBehaviour {
	
	public Transform objCentroDeRotacion;// Hace referencia al objExplosion
	public float rxSegundo = 75f; // Grados que rote por segundos	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float rRandom = Random.value % 100;
		transform.RotateAround(objCentroDeRotacion.position,Vector3.up,( rxSegundo * rRandom) * Time.deltaTime);
	}
}
