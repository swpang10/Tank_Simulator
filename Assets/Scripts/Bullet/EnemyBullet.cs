using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : Bullet
{

    private void Start()
    {
        headLayer = LayerMask.NameToLayer("Head");
        bodyLayer = LayerMask.NameToLayer("Body");
        railLayer = LayerMask.NameToLayer("Rail");
        playerLayer = LayerMask.NameToLayer("Player");
        round = GetComponentInParent<EnemyTank>().round;
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject hitObject = other.gameObject;
        int hitLayer = hitObject.layer;


        if (hitLayer == headLayer)
        {
            Debug.Log("Headshot!");
            other.GetComponentInParent<Transform>().GetComponentInParent<Transform>().GetComponentInParent<PlayerTank>().hitPos = 1;
            other.GetComponentInParent<Transform>().GetComponentInParent<Transform>().GetComponentInParent<PlayerTank>().damage = round;


        }
        else if (hitLayer == bodyLayer)
        {
            Debug.Log("Body hit.");
            other.GetComponentInParent<Transform>().GetComponentInParent<PlayerTank>().hitPos = 2;
            other.GetComponentInParent<Transform>().GetComponentInParent<PlayerTank>().damage = round;
        }
        else if (hitLayer == railLayer)
        {
            Debug.Log("Rail hit.");
            other.GetComponentInParent<Transform>().GetComponentInParent<Transform>().GetComponentInParent<PlayerTank>().hitPos = 3;
            other.GetComponentInParent<Transform>().GetComponentInParent<Transform>().GetComponentInParent<PlayerTank>().damage = round;
        }


        
        Destroy(gameObject);
    }


}
