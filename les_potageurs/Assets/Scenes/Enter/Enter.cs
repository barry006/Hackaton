using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Enter : MonoBehaviour
{
    [SerializeField] TMP_InputField longueur;
    [SerializeField] TMP_InputField largeur;
    [SerializeField] Button creerTerrain;
    [SerializeField] string sceneName;

    [SerializeField] DontDestroy dontDestroy;


    // Start is called before the first frame update

    [System.Serializable]
    public class SaveData
    {
  

    }

    [System.Serializable]
   public  class TypeDePlante
    {
        public string nomPlante;
        public Variete variete;
    }



        [System.Serializable]
  public  class Variete
    {
        public string nomPlante;  
        public Vector3 posPlayer;
        public Quaternion rotPlayer;
    }

    public void SelectMetrique()
    {
        SaveData data = new SaveData();

        if (longueur.text == "")
        {
            longueur.text = "0";
        }
        if (largeur.text == "")
        {
            largeur.text = "0";
        }
       // dontDestroy.longueur = float.Parse(longueur.text);
       // dontDestroy.largeur = float.Parse(largeur.text);
        SceneManager.LoadScene(sceneName);

    }









}
