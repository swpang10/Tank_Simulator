using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : Bullet
{
    // Start is called before the first frame update
    private void Start()
    {
        headLayer = LayerMask.NameToLayer("Head");
        bodyLayer = LayerMask.NameToLayer("Body");
        railLayer = LayerMask.NameToLayer("Rail");
        playerLayer = LayerMask.NameToLayer("Player");
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject hitObject = other.gameObject;
        int hitLayer = hitObject.layer;


        if (hitLayer == headLayer)
        {
            Debug.Log("Headshot!");
        }
        else if (hitLayer == bodyLayer)
        {
            Debug.Log("Body hit.");

        }
        else if (hitLayer == railLayer)
        {
            Debug.Log("Rail hit.");

        }
        else if (hitLayer == playerLayer)
        {
            Debug.Log("collider hit");
        }
        else
        {
            Debug.Log("Hit nothing.");
        }

        Destroy(gameObject);
    }
}
