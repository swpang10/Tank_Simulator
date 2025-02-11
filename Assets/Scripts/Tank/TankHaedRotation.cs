using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankHaedRotation : MonoBehaviour
{ 
    public float mouseSensitivity = 200f; 
    private float MouseX;


    // Start is called before the first frame update
    void Start()
    {
        
    }
        
    // Update is called once per frame
    void Update()
    {
        MouseX += Input.GetAxisRaw("Mouse X") * mouseSensitivity * Time.deltaTime;
        transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(0, MouseX, 0), 0.1f);
    
    }
}
