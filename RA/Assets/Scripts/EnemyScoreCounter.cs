using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyScoreCounter : MonoBehaviour {

	// Use this for initialization
	private int pontos = 0;
	public Text placar;
	Text text;
	private void Start() {
		GameObject PlacarReal = GameObject.FindWithTag ("Placar");
		text =PlacarReal.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void OnCollisionEnter(Collision other) {
		AtualizaPlacar();
	}
	void AtualizaPlacar(){
		placar.text = "Inimigos Mortos: " + pontos.ToString();
	}
}
