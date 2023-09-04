using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScriptTwo : MonoBehaviour
{

       public float moveSpeed = 3.0f; // Adjust the move speed as needed

       void Start()
    {
        
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horizontalInput, 0.0f, verticalInput) * moveSpeed * Time.deltaTime);
    }
//     }
    



    
    


}
