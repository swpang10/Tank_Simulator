using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{

    [SerializeField] public float round;        //����, ���ݷ� (70~150) 
    [SerializeField] public float armorPlate;   //�尩ġ, ���� (1~10)
    [SerializeField] public float headArmor;    //��ž ������    70
    [SerializeField] public float bodyArmor;    //���� ������    100
    [SerializeField] public float railArmor;    //���� ������    50
    [SerializeField] public float totalHealth;  //��ü��         100
    [SerializeField] public float moveSpeed;
    [SerializeField] public float rotateSpeed;




    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = -0.25f;
        rotateSpeed = 1f;
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

    public  void Damage(float round, float armorPlate, float targetArmor, float targetHealth)
    {
        Debug.Log("1");
        if (targetArmor != 0)
        {
            Debug.Log("2");
            targetHealth -= (round / 3 - armorPlate);
            Debug.Log("3");
            targetArmor -= (round / 3);
            if (targetArmor > 0)
            {
                Debug.Log("4");
                targetArmor = 0;
            }
        }
        else
        {
            Debug.Log("5");
            Debug.Log(targetHealth);

            targetHealth -= (round / 3);
        }
    }
}
