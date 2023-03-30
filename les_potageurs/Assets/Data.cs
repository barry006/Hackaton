using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{

    DontDestroy dontDestroy1;
    DontDestroy dontDestroy2;
    DontDestroy dontDestroy3;
    DontDestroy dontDestroy4;
    DontDestroy dontDestroy5;
    // Start is called before the first frame update
    void Start()
    {
        dontDestroy1 = GameObject.Find("DontDestroyy1").GetComponent<DontDestroy>();
        dontDestroy2 = GameObject.Find("DontDestroyy2").GetComponent<DontDestroy>();
        dontDestroy3 = GameObject.Find("DontDestroyy3").GetComponent<DontDestroy>();
        dontDestroy4 = GameObject.Find("DontDestroyy4").GetComponent<DontDestroy>();
        dontDestroy5 = GameObject.Find("DontDestroyy5").GetComponent<DontDestroy>();
        
    }



}
