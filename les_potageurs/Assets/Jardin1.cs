using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Jardin1 : MonoBehaviour
{
    DontDestroy dontDestroy;
    public GameObject go;
    public Transform goParent;
     TextMeshProUGUI surface;
     TextMeshProUGUI nbrderang;
     TextMeshProUGUI Planche;


    // Start is called before the first frame update
    void Start()
    {
        /*
        dontDestroy = GameObject.Find("DontDestroyy1").GetComponent<DontDestroy>();
        for (int i = 0; i < dontDestroy.nbrRang.Count; i++)
        {
            GameObject instantiatedGo = Instantiate(go, goParent);
            //Instantiate(go, goParent);

            surface = instantiatedGo.transform.Find("Surfaceeeeeeeeeee").GetComponent<TextMeshProUGUI>();
            nbrderang = instantiatedGo.transform.Find("NbrDeRanggggggg").GetComponent<TextMeshProUGUI>();
            Planche = instantiatedGo.transform.Find("Plancheeeeeee").GetComponent<TextMeshProUGUI>();

            surface.text = "Surface : "+dontDestroy.surfaces[i].ToString()+"m²";
            nbrderang.text = "Nombres de rang : " + dontDestroy.nbrRang[i].ToString();
            Planche.text = "Planche "+ (i+1)+" : " ;
        }      */
    } 
}


