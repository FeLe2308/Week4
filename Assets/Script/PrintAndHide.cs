using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    // Start is called before the first frame update

    public Renderer rend;
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
