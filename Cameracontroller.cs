using UnityEngine;
using System.Collections;
public class CameraController : MonoBehaviour
{
	//this program makes a plane in unity access the device camera
	public WebCamTexture mCamera = null;
	public GameObject plane;
	// Use this for initialization
	void Start ()
	{
		Debug.Log ("Script has been started");
		plane = GameObject.FindWithTag ("Player");
		mCamera = new WebCamTexture ();
		plane.renderer.material.mainTexture = mCamera;
		mCamera.Play ();
	}
	// Update is called once per frame
	void Update ()
	{
	}
}
