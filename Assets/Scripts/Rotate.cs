using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public float downSpeed = 0.1f;
    public float minTumble = 1f;
    public float maxTumble = 3f;

    protected Rigidbody rb;

    void Start()
    {
        float tumble = Random.Range(minTumble, maxTumble);

        rb = GetComponent<Rigidbody>();
        rb.angularVelocity = Random.insideUnitSphere * tumble;        
    }

    void FixedUpdate()
    {
        Vector3 target = transform.position;
        target.z -= downSpeed;
        rb.MovePosition(target);
    }
}
