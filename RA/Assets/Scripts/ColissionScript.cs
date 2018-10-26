using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColissionScript : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider other) {
		GameObject explosion = Instantiate(Resources.Load(
			"FlareMobile", typeof(GameObject))) as GameObject;
			explosion.transform.position = transform.position;
			if(other.gameObject.CompareTag("Inimigo")){
				Destroy(other.gameObject);
			}
			Destroy(explosion, 0.5f);
			if(GameObject.FindGameObjectsWithTag("Inimigo").Length == 0){
				GameObject Inimigo = Instantiate(Resources.Load("Inimigo",typeof(GameObject))) as GameObject;
				GameObject Inimigo2 = Instantiate(Resources.Load("Inimigo2",typeof(GameObject))) as GameObject;
				GameObject Inimigo3 = Instantiate(Resources.Load("Inimigo3",typeof(GameObject))) as GameObject;
			}	
	}
}
