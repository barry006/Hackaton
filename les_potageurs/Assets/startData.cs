using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class startData : MonoBehaviour
{
    public GameObject go;
    public GameObject goParent;
    public GameObject goRang;
    public GameObject finTextData;
    TextMeshProUGUI surface;
    TextMeshProUGUI nbrderang;
    TextMeshProUGUI Planche;
    TransferAll transferAll;
    void Start()
    {
        transferAll = GameObject.Find("DontDestroyy1").GetComponent<TransferAll>();

        for (int i = 0; i < transferAll.dontDestroy.Count; i++)
        {
            if (transferAll.dontDestroy[i].nbrRang.Count > 0)
            {
                CreateAndModifStartData(transferAll.dontDestroy[i], "Jardin " + (i + 1) + " -  " + transferAll.dontDestroy[i].nomJardin + " :");
            }
        }
        Instantiate(finTextData, goParent.transform);
    }
    public void CreateAndModifStartData(DontDestroy dontDestroy, string nameJardin)
    {
        GameObject newGameObject = Instantiate(go, goParent.transform);
        TextMeshProUGUI textJardin = newGameObject.transform.Find("Mon Jardin text").GetComponent<TextMeshProUGUI>();
        textJardin.text = nameJardin;
        Transform goRangParent = newGameObject.transform;
        for (int i = 0; i < dontDestroy.nbrRang.Count; i++)
        {
            GameObject instantiatedGo = Instantiate(goRang, goRangParent);
            surface = instantiatedGo.transform.Find("Surfaceeeeeeeeeee").GetComponent<TextMeshProUGUI>();
            nbrderang = instantiatedGo.transform.Find("NbrDeRanggggggg").GetComponent<TextMeshProUGUI>();
            Planche = instantiatedGo.transform.Find("Plancheeeeeee").GetComponent<TextMeshProUGUI>();
            surface.text = "Surface : " + dontDestroy.surfaces[i].ToString() + "m²";
            nbrderang.text = "Nombres de rang : " + dontDestroy.nbrRang[i].ToString();
            Planche.text = "Planche " + (i + 1) + " : ";
        }
    }
}
