using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour {

	// Use this for initialization
	public GameObject webCamPlane;
	public Button fire;
	void Start () {
		WebCamTexture webCamTex = new WebCamTexture();
		webCamPlane.GetComponent<MeshRenderer>().material.mainTexture = webCamTex;
		webCamTex.Play();
		Input.gyro.enabled = true;
		fire.onClick.AddListener(Shot);
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
		rb.AddForce(Camera.main.transform.forward * 500f);
		Destroy(bullet, 3.0f);
		GetComponent<AudioSource>().Play();
	}
}
