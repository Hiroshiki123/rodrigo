using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    Vector2 move;
    // Start is called before the first frame update

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(move.x* 5.0f,rb.velocity.y,move.y*5.0f);
    }
    
    public void SetMove(InputAction.CallbackContext value)
    {
        move = value.ReadValue<Vector2>();
    }
    public void SetJump(InputAction.CallbackContext value) 
    {
        rb.AddForce(Vector3.up * 100);
    }
}
