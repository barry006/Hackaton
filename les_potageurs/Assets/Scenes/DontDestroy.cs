using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public float longueur = 0f;
    public float largeur = 0f;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

}
