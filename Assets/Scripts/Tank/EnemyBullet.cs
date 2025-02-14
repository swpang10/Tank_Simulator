using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{

    private int headLayer;
    private int bodyLayer;
    private int railLayer;

    private void Start()
    {
        headLayer = LayerMask.NameToLayer("Head");
        bodyLayer = LayerMask.NameToLayer("Body");
        railLayer = LayerMask.NameToLayer("Rail");
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject hitObject = collision.gameObject;
        int hitLayer = hitObject.layer;

        // 레이어별 동작
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
        else
        {
            Debug.Log("Hit nothing.");
        }
        Destroy(gameObject);
    }
}
