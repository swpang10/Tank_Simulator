using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : Tank
{

    protected int headLayer;
    protected int bodyLayer;
    protected int railLayer;
    protected int playerLayer;
    protected int enemyLayer;
    public EnemyTank shootTank;
    public PlayerTank hitTank;

    private void Start()
    {
        
    }

    
}
