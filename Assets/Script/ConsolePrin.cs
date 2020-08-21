using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ConsolePrin : MonoBehaviour
{
    // Start is called before the first frame update
    public string objectName;
    int i = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(gameObject.name + ": " + i);
        i++;
    }
}
