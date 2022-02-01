using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FollowType{
    Strict, Smooth
}

public class FollowingCamera : MonoBehaviour
{
    public Transform target;
    public FollowType type;

    public float smoothness=1.0f;
    private Vector3 offset;
    
    void Start()
    {
        offset= transform.position - target.position;
    }

    void LateUpdate()
    {
        switch(type){
            case FollowType.Strict:
            transform.position= target.position + offset;
            break;
            case FollowType.Smooth:
            transform.position= Vector3.Lerp(transform.position, target.position + offset, smoothness* Time.deltaTime);
            break;
        }        
    }
}
