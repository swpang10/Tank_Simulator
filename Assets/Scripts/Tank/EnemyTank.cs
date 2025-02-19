using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTank : Tank
{
    public Tank ememy;

    // Start is called before the first frame update
    void Start()
    {
        ememy = this;
        ememy.InitializeStatus();
    }

    // Update is called once per frame
    void Update()
    {
        if (reloading < reloadSpeed)
        {
            reloading += Time.deltaTime;
        }
        if (ememy.hitPos == 1)
        {

            Damage(ememy, this.damage, hitPos);
            this.damage = 0;
            this.hitPos = 0;
        }
        else if (ememy.hitPos == 2)
        {
            Damage(ememy, this.damage, hitPos);
            this.damage = 0;
            this.hitPos = 0;
        }
        else if (ememy.hitPos == 3)
        {
            Damage(ememy, this.damage, hitPos);
            this.damage = 0;
            this.hitPos = 0;
        }
        if (this.curHealth <= 0)
        {
            IsAlive(this);
        }
    }
}
