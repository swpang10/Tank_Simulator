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

    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject hitObject = other.gameObject;
        int hitLayer = hitObject.layer;


        if (hitLayer == headLayer)
        {
            Debug.Log("Headshot!");
            hitTank.Damage(shootTank.round, hitTank.armorPlate, hitTank.headArmor, hitTank.totalHealth);
            Debug.Log("10");
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
