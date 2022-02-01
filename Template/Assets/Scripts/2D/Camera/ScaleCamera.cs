using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ScaleCamera : MonoBehaviour
{
    public int mTargetWidth_= 640;
	public float pixelsToUnits = 100;

	Camera mCamera_;
	int orthoHeight;

	void Start()
	{
		mCamera_ = Camera.main;
	}

	void Update() 
	{
		orthoHeight = Mathf.RoundToInt(mTargetWidth_ / (float)Screen.width * Screen.height);
		mCamera_.orthographicSize = orthoHeight/pixelsToUnits*0.5f;
	}
}
