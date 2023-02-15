using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texter : MonoBehaviour
{
    public Text test;
    // Start is called before the first frame update
    void Start()
    {
        test = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeText(string word)
    {
        test.text = word;
    }
}
