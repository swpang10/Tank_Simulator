using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : Bullet
{
    // Start is called before the first frame update
    private void Start()
    {
        headLayer = LayerMask.NameToLayer("EnemyHead");
        bodyLayer = LayerMask.NameToLayer("EnemyBody");
        railLayer = LayerMask.NameToLayer("EnemyRail");
        enemyLayer = LayerMask.NameToLayer("Enemy");
        round = GetComponentInParent<PlayerTank>().round;
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject hitObject = other.gameObject;
        int hitLayer = hitObject.layer;


        if (hitLayer == headLayer)
        {
            Debug.Log("Headshot!");
            other.GetComponentInParent<Transform>().GetComponentInParent<Transform>().GetComponentInParent<EnemyTank>().hitPos = 1;
            other.GetComponentInParent<Transform>().GetComponentInParent<Transform>().GetComponentInParent<EnemyTank>().damage = round;

        }
        else if (hitLayer == bodyLayer)
        {
            Debug.Log("Body hit.");
            other.GetComponentInParent<Transform>().GetComponentInParent<EnemyTank>().hitPos = 2;
            other.GetComponentInParent<Transform>().GetComponentInParent<EnemyTank>().damage = round;        
        }
        else if (hitLayer == railLayer)
        {
            Debug.Log("Rail hit.");
            other.GetComponentInParent<Transform>().GetComponentInParent<Transform>().GetComponentInParent<EnemyTank>().hitPos = 3;
            other.GetComponentInParent<Transform>().GetComponentInParent<Transform>().GetComponentInParent<EnemyTank>().damage = round;
        }


        enemyTank.damage = round;
        Destroy(gameObject);
    }
}
