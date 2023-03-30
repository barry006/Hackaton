using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class StartTerrain : MonoBehaviour
{
    [SerializeField] Image imgTerrain;
    DontDestroy dontDestroy;

    void Start()
    {
        dontDestroy = FindObjectOfType<DontDestroy>();


      //  Vector3 newScale = new Vector3(dontDestroy.longueur, dontDestroy.largeur, 1f);

      //  imgTerrain.rectTransform.localScale = newScale;




    }

    // Update is called once per frame
    void Update()
    {

    }
}
