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
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
