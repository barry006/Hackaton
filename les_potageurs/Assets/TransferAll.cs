using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using System.IO;
using UnityEngine.SceneManagement;
public class TransferAll : MonoBehaviour
{
    public List<DontDestroy> dontDestroy = new List<DontDestroy>();

    public void transferr()
    {
        for (int i = 0; i < dontDestroy.Count; i++)
        {
            dontDestroy[i].Transfert();
        }
        SceneManager.LoadScene(1);
    }
   
 }
