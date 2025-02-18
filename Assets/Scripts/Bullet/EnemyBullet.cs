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
            hitTank.hitPos = 1;
            
        }
        else if (hitLayer == bodyLayer)
        {
            Debug.Log("Body hit.");
            hitTank.hitPos = 2;
        }
        else if (hitLayer == railLayer)
        {
            Debug.Log("Rail hit.");
            hitTank.hitPos = 3;
        }

        
        Debug.Log(hitPos);
        hitTank.damage = round;
        Destroy(gameObject);
    }


}
