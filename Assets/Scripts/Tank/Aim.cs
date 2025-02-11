using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    public Camera cm1;
    public Camera cm2;

    // Start is called before the first frame update
    void Start()
    {
        cm1.enabled = true;
        cm2.enabled = false;
        Debug.Log(cm1.enabled);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (cm1.enabled)
            {
                Debug.Log(cm1.enabled);
                cm1.enabled = false;
                cm2.enabled = true;
            }
            else if (cm2.enabled)
            {
                Debug.Log(cm1.enabled);
                cm1.enabled = true;
                cm2.enabled = false;
            }
        }
    }
}
