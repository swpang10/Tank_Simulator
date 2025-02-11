using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject bullet;
    public GameObject barrelEnd;

     private Rigidbody b;
    private Rigidbody backForce;
    private Vector3 FireForce;

    // Start is called before the first frame update
    void Start()
    {
        FireForce = barrelEnd.transform.up;
        backForce = transform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        FireForce = barrelEnd.transform.up;
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject bulletInstance = Instantiate(bullet, barrelEnd.transform.position, barrelEnd.transform.rotation);
            Rigidbody b = bulletInstance.GetComponent<Rigidbody>(); 
           
            b.AddForce(FireForce * 200, ForceMode.Impulse); 
            backForce.AddForce(-FireForce * 200);        
        }
    }
}
