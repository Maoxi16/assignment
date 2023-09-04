using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScriptThree : MonoBehaviour
{
    
  float degreesPerSecond = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(new Vector3(0, degreesPerSecond, 0) * Time.deltaTime);
        
       
    }
}
