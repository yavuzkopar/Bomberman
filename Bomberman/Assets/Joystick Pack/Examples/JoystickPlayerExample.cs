using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public FixedJoystick variableJoystick;
    public Rigidbody rb;
    private PlayerController playerCtrl;

    private void Start()
    {
        playerCtrl = FindObjectOfType<PlayerController>();
    }
    public void FixedUpdate()
    {
        Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
     //   rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
        
    }
}