using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    [SerializeField] public float round;        //����, ���ݷ�
    [SerializeField] public float armorPlate;   //�尩ġ, ����
    [SerializeField] public float headArmor;    //��ž ������
    [SerializeField] public float bodyArmor;    //���� ������
    [SerializeField] public float railArmor;    //���� ������
    [SerializeField] public float totalHealth;  //��ü��

    
       
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
