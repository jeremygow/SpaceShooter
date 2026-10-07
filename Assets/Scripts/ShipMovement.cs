using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShipMovement : MonoBehaviour
{

    public float speed = 0.2f;
    protected Rigidbody rb;

    // Bounds
    public Rect bounds = new Rect(-4.5f,-1.8f,9f,3.8f);

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Read movement vector
        InputAction input = InputManager.instance.moveAction;
        Vector2 delta = input.ReadValue<Vector2>();

        // Move ship
        Vector3 movement = new Vector3(delta.x, 0.0f, delta.y);
        rb.velocity = movement * speed;

        // Respect bounds
        rb.position = new Vector3(
            Mathf.Clamp(rb.position.x, bounds.xMin, bounds.xMax),
            0.0f,
            Mathf.Clamp(rb.position.z, bounds.yMin, bounds.yMax)
            );
        
    }
}
