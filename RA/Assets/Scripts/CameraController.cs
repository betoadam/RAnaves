using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour {

	// Use this for initialization
	public GameObject webCamPlane;
	public Button fire;
	public Button fire2;
	void Start () {
		WebCamTexture webCamTex = new WebCamTexture();
		webCamPlane.GetComponent<MeshRenderer>().material.mainTexture = webCamTex;
		webCamTex.Play();
		Input.gyro.enabled = true;
		fire.onClick.AddListener(Shot);
		fire2.onClick.AddListener(Shot2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void LateUpdate()
	{
		Quaternion cameraRotation = new Quaternion(
			Input.gyro.attitude.x,
			Input.gyro.attitude.y,
			Input.gyro.attitude.z,
			Input.gyro.attitude.w
		);
		transform.localRotation = cameraRotation;
	}
	void Shot(){
		GameObject bullet = Instantiate(Resources.Load("bullet",typeof(GameObject))) as GameObject;
		Rigidbody rb = bullet.GetComponent<Rigidbody>();
		bullet.transform.position = Camera.main.transform.position;
		bullet.transform.rotation = Camera.main.transform.rotation;
		rb.AddForce(Camera.main.transform.forward * 900f);
		Destroy(bullet, 3.0f);
		GetComponent<AudioSource>().Play();
	}

	void Shot2(){
		GameObject bullet2 = Instantiate(Resources.Load("bullet2",typeof(GameObject))) as GameObject;
		Rigidbody rb2 = bullet2.GetComponent<Rigidbody>();
		bullet2.transform.position = Camera.main.transform.position;
		bullet2.transform.rotation = Camera.main.transform.rotation;
		rb2.AddForce(Camera.main.transform.forward * 900f);
		Destroy(bullet2, 3.0f);
		GetComponent<AudioSource>().Play();
	}
}
