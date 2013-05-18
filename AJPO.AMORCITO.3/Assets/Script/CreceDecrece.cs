using UnityEngine;
using System.Collections;

public class CreceDecrece : MonoBehaviour {
	
	public Transform transform = null;
	private Manipulador m = null;
	
	// Use this for initialization
	void Start () {
		m = new Manipulador(transform.localScale);
	}
	
	// Update is called once per frame
	void Update () {
		// parto de 0.01 y debo llegar a 0.05
		// y luego volver
		m.manipular();
		transform.localScale = new Vector3(m.x,m.y,m.z);
	}
	
	class Manipulador {
		private float xini,yini,zini = 0.01f;
		private float xfin,yfin,zfin = 0.05f;
		public float x,y,z = 0f;
		float incremento = 0.1f;
		public Manipulador(Vector3 v3){
			this.x = v3.x;
			this.y = v3.y;
			this.z = v3.z;
		}
			
		/*
		 * Incrementa o decrementa 
		 * 
		 */
		public void manipular(){
			if(incremento > 0){
				if(x <=xfin || y <=yfin || z <= zfin ){
					x = (x + (incremento*Time.deltaTime));
					y = (y + (incremento*Time.deltaTime));
					z = (z + (incremento*Time.deltaTime));
				}else{
					incremento = incremento  * -1;	
				}
			}else{
				if(x >=xfin || y >=yfin || z >= zfin ){
					x = (x + (incremento*Time.deltaTime));
					y = (y + (incremento*Time.deltaTime));
					z = (z + (incremento*Time.deltaTime));
				}else{
					incremento = incremento  * -1;		
				}
			}
		}
	}
}
