using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;
using TMPro;

public class DontDestroy : MonoBehaviour
{
    public string nomJardin;
    TMP_InputField inputFieldLongueur;
    TMP_InputField inputFieldLargeur;
    TMP_InputField inputFieldRang;

    public List<GameObject> planche = new List<GameObject>();

    public List<int> nbrRang = new List<int>();
    public List<float> surfaces = new List<float>();
    public List<float> surfacesParRang = new List<float>();
    
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void Transfert()
    {    

        foreach (GameObject go in planche)
        {

            inputFieldLongueur = go.transform.Find("Longueur").GetComponent<TMP_InputField>();
            inputFieldLargeur = go.transform.Find("Largeur").GetComponent<TMP_InputField>();
            inputFieldRang = go.transform.Find("NbrDeRang").GetComponent<TMP_InputField>();
            
            float longueur = float.Parse(inputFieldLongueur.text);
            float largeur = float.Parse(inputFieldLargeur.text);
            int rang = int.Parse(inputFieldRang.text);

            float fsurface = longueur * largeur;
            float fsurfacesParRang = fsurface / rang;
            surfaces.Add(fsurface);
            surfacesParRang.Add(fsurfacesParRang);
            nbrRang.Add(rang);     
        }

        if (planche.Count > 0)
        {
            
            planche.Clear();
        }

    }
}
