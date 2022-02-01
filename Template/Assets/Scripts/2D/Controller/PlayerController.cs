using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction{Up, Right, Left, Down}
public class PlayerController : MonoBehaviour
{
    public string horizontal= "Horizontal";
    public string vertical= "Vertical";

    private Direction mDir_;
    Animator anim;
    Rigidbody2D rb;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
