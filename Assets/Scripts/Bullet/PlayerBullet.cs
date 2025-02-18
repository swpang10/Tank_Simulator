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
        round = GetComponentInParent<PlayerTank>().player.round;
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject hitObject = other.gameObject;
        int hitLayer = hitObject.layer;


        if (hitLayer == headLayer)
        {
            Debug.Log("Enemy Head hit!");
        }
        else if (hitLayer == bodyLayer)
        {
            Debug.Log("Enemy Body Body.");

        }
        else if (hitLayer == railLayer)
        {
            Debug.Log("Enemy Rail hit.");

        }
        else if (hitLayer == enemyLayer)
        {
            Debug.Log("Enemy hit");
        }
        else
        {
            Debug.Log("Hit nothing.");
        }

        Destroy(gameObject);
    }
}
