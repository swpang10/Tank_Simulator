using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tank : MonoBehaviour
{

    public float round;  //����, ���ݷ� (70~150)
    public float armorPlate;     //�尩ġ, ���� (1~10)
    public float headArmor;     //��ž ������    70
    public float bodyArmor;     //���� ������    100
    public float railArmor;     //���� ������    50
    public float totalHealth;  //��ü��         100
    public float curHealth;
    public float moveSpeed;
    public float rotateSpeed;
    public float reloadSpeed;
    public float reloading;
    public float damage;

    public int hitPos = 0;

    private void Awake()
    {
        curHealth = totalHealth;
    }

    public void TakeDamage(int damage)
    {
        curHealth -= damage;
    }



    public void InitializeStatus()
    {
        round = 150;
        moveSpeed = -0.02f;
        reloadSpeed = 4.0f;
        rotateSpeed = 0.4f;
        headArmor = 70;
        bodyArmor = 100;
        railArmor = 50;
        totalHealth = 100;
        curHealth = totalHealth;
        armorPlate = 10;
        reloading = reloadSpeed;
    }

    


    // Start is called before the first frame update
    void Start()
    {
     

    }


    // Update is called once per frame
    void Update()
    {
        
        
    }



    public void Damage(Tank target, float round, int hitPos)
    {
        switch (hitPos)
        {
            case 1:
                if (target.headArmor != 0)
                {
                    Debug.Log("�Ӹ� �Ƹ� ����");
                    target.curHealth -= (round / 5 - target.armorPlate);
                    target.headArmor -= (round / 3);
                    if (target.headArmor <= 0)
                    {
                        Debug.Log("�Ӹ� �Ƹ� �ı�");
                        target.reloadSpeed +=2;
                        target.headArmor = 0;
                    }
                }
                else
                {
                    Debug.Log("�ƸӾ���");
                    target.curHealth -= (round / 5);
                }
                break;
            case 2:
                if (target.bodyArmor != 0)
                {
                    Debug.Log("���� �Ƹ� ����");
                    target.curHealth -= (round / 5 - target.armorPlate);
                    target.bodyArmor -= (round / 3);
                    if (target.bodyArmor <= 0)
                    {
                        Debug.Log("���� �Ƹ� �ı�");
                        target.reloadSpeed += 2;
                        target.headArmor = 0;
                    }
                }

                else
                {
                    Debug.Log("�ƸӾ���");
                    Debug.Log(target.curHealth);
                    target.curHealth -= (round / 5);
                }
                break;
            case 3:
                if (target.railArmor != 0)
                {
                    Debug.Log("���� �Ƹ� ����");
                    target.curHealth -= (round / 5 - target.armorPlate);
                    target.railArmor -= (round / 3);
                    if (target.railArmor <= 0)
                    {
                        Debug.Log("���� �Ƹ� �ı�");
                        target.moveSpeed /= 2f;
                        target.rotateSpeed /= 2f;
                        target.railArmor = 0;
                    }
                }
                else
                {
                    Debug.Log("�ƸӾ���");
                    Debug.Log(target.curHealth);
                    target.curHealth -= (round / 5);
                }
                break;
        }       
     }


    public void IsAlive(Tank tank)
    {
        if (tank.curHealth <= 0)
        {
            tank.transform.gameObject.SetActive(false);
        }      
    }

}
