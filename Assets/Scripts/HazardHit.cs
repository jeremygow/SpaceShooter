using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardHit : MonoBehaviour
{

    public string hazardTag;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == hazardTag)
        {
            Debug.Log("Game over");
        }
    }
}
