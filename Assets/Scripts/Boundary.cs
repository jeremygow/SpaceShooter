using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // Destroy anything that collide with this boundary
        GameObject.Destroy(other.gameObject);
    }

}
