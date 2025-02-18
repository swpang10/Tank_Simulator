using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTank : Tank
{

   public Tank player;

    // Start is called before the first frame update
    void Start()
    {
        player = this;
        player.InitializeStatus();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(new Vector3(player.moveSpeed, 0, 0));
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(new Vector3(-player.moveSpeed, 0, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(new Vector3(0, player.rotateSpeed, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(new Vector3(0, -player.rotateSpeed, 0));
        }





        Debug.Log(player.hitPos);
        if (player.hitPos == 1)
        {
            Debug.Log("머리맞음");
            Damage(player, this.damage, hitPos);
            this.damage = 0;
            this.hitPos = 0;
        }
        else if (player.hitPos == 2)
        {
            Damage(player, this.damage, hitPos);
            this.damage = 0;
            this.hitPos = 0;
        }
        else if (player.hitPos == 3)
        {
            Damage(player, this.damage, hitPos);
            this.damage = 0;
            this.hitPos = 0;
        }
    }


    public void updateStatus()
    {
        totalHealth = player.totalHealth;
    }




}
