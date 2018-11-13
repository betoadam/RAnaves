using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColissionScript : MonoBehaviour {
	public GameController gameController;
	void Start() {
		GameObject gameControllerObject = GameObject.FindWithTag ("Placar");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent <GameController>();
        }
        if (gameController == null)
        {
            Debug.Log ("Cannot find 'GameController' script");
        }
	}
	void Update()
	{
		if(GameObject.FindGameObjectsWithTag("Inimigo").Length < 3){
				GameObject Inimigo = Instantiate(Resources.Load("Inimigo",typeof(GameObject))) as GameObject;
				GameObject Inimigo2 = Instantiate(Resources.Load("Inimigo2",typeof(GameObject))) as GameObject;
				GameObject Inimigo3 = Instantiate(Resources.Load("Inimigo3",typeof(GameObject))) as GameObject;
			}	
	}
	void OnTriggerEnter(Collider other) {
		GameObject explosion = Instantiate(Resources.Load(
			"FlareMobile", typeof(GameObject))) as GameObject;
			explosion.transform.position = transform.position;
			if(other.gameObject.CompareTag("Inimigo")){
				if(this.gameObject.CompareTag("bull1"))
					Destroy(other.gameObject);
					gameController.AddScore (1);
			}
			if(other.gameObject.CompareTag("Inimigo2")){
				if(this.gameObject.CompareTag("bull2"))
					Destroy(other.gameObject);
					gameController.AddScore (1);
			}
			Destroy(explosion, 0.5f);
			Debug.Log(GameObject.FindGameObjectsWithTag("Inimigo").Length);
			if(GameObject.FindGameObjectsWithTag("Inimigo").Length < 3){
				GameObject Inimigo = Instantiate(Resources.Load("Inimigo",typeof(GameObject))) as GameObject;
				GameObject Inimigo2 = Instantiate(Resources.Load("Inimigo2",typeof(GameObject))) as GameObject;
				GameObject Inimigo3 = Instantiate(Resources.Load("Inimigo3",typeof(GameObject))) as GameObject;
			}	
	}


}
