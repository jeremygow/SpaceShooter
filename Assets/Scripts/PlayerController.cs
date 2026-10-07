using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    // Movement
    [Header("Movement")]
    public float speed = 0.2f;
    public float tilt = 5f;
    protected Rigidbody rb;

    // Bounds
    public Rect bounds = new Rect(-4.5f, -1.8f, 9f, 3.8f);

    // Weapon
    [Header("Weapon")]
    public Transform boltSpawnPoint;
    public GameObject bolt;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        bool firing = InputManager.instance.fireAction.triggered;
        if (firing) Fire();
    }

    void FixedUpdate()
    {
        MoveShip();
        ClampShip();
        TiltShip();
    }

    void Fire()
    {
        Instantiate(bolt, boltSpawnPoint.position, boltSpawnPoint.rotation);
    }

    void MoveShip() {

        // Read movement vector
        InputAction input = InputManager.instance.moveAction;
        Vector2 delta = input.ReadValue<Vector2>();

        // Move ship
        Vector3 movement = new Vector3(delta.x, 0.0f, delta.y);
        rb.velocity = movement * speed;
    }

    void ClampShip() {

        // Respect bounds
        rb.position = new Vector3(
            Mathf.Clamp(rb.position.x, bounds.xMin, bounds.xMax),
            0.0f,
            // Bound ship's z-value by boundary Rect's y-value
            Mathf.Clamp(rb.position.z, bounds.yMin, bounds.yMax)
            );
    }

    void TiltShip() {
        // Tilt the ship as it moves
        float rotation = rb.velocity.x * tilt * -1f;
        rb.rotation = Quaternion.Euler(0, 0, rotation);
    }
}
