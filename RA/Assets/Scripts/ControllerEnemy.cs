using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerEnemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine("TrocaDirecao");
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward * 3f * Time.deltaTime);	
	}
	IEnumerator TrocaDirecao(){
		while(true){
			yield return new WaitForSeconds(3.0f);
			transform.eulerAngles += new Vector3(0.0f, 180.0f, 0.0f);
		}
	}
}
