using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class PixelPerfectCamera : MonoBehaviour {

	public float pixelsToUnits = 100;

	Camera mCamera_;

	void Start()
	{
		mCamera_ = Camera.main;
	}

	void Update () {

		mCamera_.orthographicSize = Screen.height/pixelsToUnits*0.5f;
	}
}