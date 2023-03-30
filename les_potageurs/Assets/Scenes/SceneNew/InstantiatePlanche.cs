using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InstantiatePlanche : MonoBehaviour
{
    public GameObject objectToInstantiate;
    public TMP_InputField inputField;
    public Transform parentTransform;

    public DontDestroy dontDestroy;

    public void InstantiateObjects()
    {
        if (inputField.text != "")
        {
            foreach (Transform child in parentTransform.transform)
            {
                Destroy(child.gameObject);
                dontDestroy.planche.Clear();
            }


            int numObjectsToInstantiate = int.Parse(inputField.text);
            for (int i = 0; i < numObjectsToInstantiate; i++)
            {
             


                GameObject instantiatedObject = Instantiate(objectToInstantiate, parentTransform);
                TextMeshProUGUI textMeshPro = instantiatedObject.transform.Find("plancheeeeeee").GetComponent<TextMeshProUGUI>();
                textMeshPro.text = "Planche " + (i + 1);
                dontDestroy.planche.Add(instantiatedObject);
            }
        }
    }
}
