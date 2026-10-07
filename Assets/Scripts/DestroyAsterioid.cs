using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAsterioid : MonoBehaviour
{

    public string destroyTag = "Bolt";

    private void OnCollisionEnter(Collision collision)
    {
        GameObject thing = collision.gameObject;

        if (thing.tag == destroyTag)
        {
            GameObject.Destroy(gameObject);
            GameObject.Destroy(this);
            GameManager.GetInstance().ScoreAsteroid();
        }
    }
}
