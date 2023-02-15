using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInput : MonoBehaviour
{
    bool red;
    public GameObject TextGameObject;
    public Texter test;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().material.color = new Color(0, 0, 255);
        test.ChangeText("Red");
        red = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))

            if (red)
            {
                GetComponent<SpriteRenderer>().material.color = new Color(255, 0, 0);
                test.ChangeText("Red");
                red = false;
            }

            else if (Input.GetKeyDown(KeyCode.Space))

                if (!red)
                {
                    GetComponent<SpriteRenderer>().material.color = new Color(0, 255, 0);
                    test.ChangeText("Green"); 
                    red = true;
                } 
                
    }
}
