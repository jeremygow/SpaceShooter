using UnityEngine;

public class MoveAsteroid : MonoBehaviour
{

    [Header("Movement")]
    public float minSpeed = 0.05f;
    public float maxSpeed = 0.2f;
    protected float speed;

    [Header("Spin")]
    public float minSpin = 1f;
    public float maxSpin = 3f;

    protected Rigidbody rb;

    void Start()
    {
        float tumble = Random.Range(minSpin, maxSpin);

        rb = GetComponent<Rigidbody>();
        rb.angularVelocity = Random.insideUnitSphere * tumble;

        speed = Random.Range(minSpeed, maxSpeed);
    }

    void FixedUpdate()
    {
        Vector3 target = transform.position;
        target.z -= speed;
        rb.MovePosition(target);
    }
}
