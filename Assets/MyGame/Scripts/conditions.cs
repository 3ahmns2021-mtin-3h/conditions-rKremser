using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conditions : MonoBehaviour
{


    public bool A = false;
    public bool B = false;
    public bool C = false;

    public GameObject image;

    private float time;

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            time += Time.deltaTime;
            if (time > 3)
            {
                Debug.Log("Space Pressed " + time);
                A = true;
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            time = 0;
        }

    }

    

  
    public void ButtonPressed()
    {
        Debug.Log("Button Pressed");

        B = true;

        image.SetActive(false);

        C = true;
    }

    public void check()
    {
        Debug.Log("check: " + (A && B && C));
    }

    
}
