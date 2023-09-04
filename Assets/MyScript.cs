using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    public GameObject button;
    public float a = 2;
    public bool b = false;
    public string str = "The cake is a lie!";
    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log(a);
        
        //< button type = "button"  class = "finish"> Enter </ button >
    }

    
    // Update is called once per frame
    void Update()
    {   
       if (Input.GetKeyDown(KeyCode.Return)) // Check for Enter key press
        {
            Debug.Log(str); // Print the string variable on Enter key press
        }
        
            }
}
