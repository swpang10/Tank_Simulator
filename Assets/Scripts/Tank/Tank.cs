using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    [SerializeField] public float round;        //구경, 공격력
    [SerializeField] public float armorPlate;   //장갑치, 방어력
    [SerializeField] public float headArmor;    //포탑 내구도
    [SerializeField] public float bodyArmor;    //몸통 내구도
    [SerializeField] public float railArmor;    //레일 내구도
    [SerializeField] public float totalHealth;  //총체력

    
       
    // Start is called before the first frame update
    void Start()
    {
        headArmor = 70;
        bodyArmor = 100;
        railArmor = 50;
        totalHealth = 100;
        armorPlate = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
