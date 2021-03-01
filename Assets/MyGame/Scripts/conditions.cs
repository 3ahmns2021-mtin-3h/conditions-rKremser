using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conditions : MonoBehaviour
{


    public bool space3Seconds = false;
    public bool buttonPressed = false;

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
                space3Seconds = true;
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

        buttonPressed = true;

        image.SetActive(false);
    }
}
