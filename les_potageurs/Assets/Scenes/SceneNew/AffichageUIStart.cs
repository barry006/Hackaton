using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class AffichageUIStart : MonoBehaviour
{
    public TMP_InputField inputField;
    public GameObject uiPrefab;
    public Transform parentTransform;
    private void Start()
    {
        // Ajouter un listener pour l'événement OnEndEdit
        inputField.onEndEdit.AddListener(OnEndEdit);
    }

    private void OnEndEdit(string value)
    {
        // Faire quelque chose lorsque l'utilisateur termine la saisie
        Debug.Log("Entrée détectée: " + value);

        GameObject uiObject = Instantiate(uiPrefab, parentTransform);

    }
    /*
    private void Update()
    {
        if(inputField.text != "")
        {
            int num = int.Parse(inputField.text);
        }
    }
    */
}
