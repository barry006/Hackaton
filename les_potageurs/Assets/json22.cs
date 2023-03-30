using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Newtonsoft.Json;
using UnityEngine.Networking;
using System.IO;
using System;

using System.Text;


public class json22 : MonoBehaviour
{

    [Serializable]


    public class Rootobject
    {
        [JsonProperty("Types de jardins")]
        public List<TypeDeJardin> TypesDeJardins { get; set; }
    }

    public class TypeDeJardin
    {
        [JsonProperty("Solanacées")]
        public List<string> Solanacees { get; set; }

        [JsonProperty("Verdures et racines")]
        public List<string> VerduresEtRacines { get; set; }

        [JsonProperty("Ail")]
        public List<string> Ail { get; set; }

        [JsonProperty("Cucurbitacées / Crucifères / Brassicacées")]
        public List<string> CucurbitaceesCruciferesBrassicacees { get; set; }

        [JsonProperty("Litiacées")]
        public List<string> Litiacees { get; set; }
    }

    // Start is called before the first frame update
    void Start()
    {




        string jsonFilePath = Application.dataPath + "/types_de_jardins.json";
        //string jsonString = File.ReadAllText(jsonFilePath);
        string jsonString = File.ReadAllText(jsonFilePath, Encoding.Default);
        Debug.Log(jsonString);
        /*
       // Rootobject response = JsonConvert.DeserializeObject<Rootobject>(jsonString);
        List<Rootobject> response = JsonConvert.DeserializeObject<List<Rootobject>>(File.ReadAllText(jsonFilePath));
        */
        List<Rootobject> rootObjects = JsonConvert.DeserializeObject<List<Rootobject>>(jsonString);


        // Accéder à "Echalottes"
        string echalottes = rootObjects[1].TypesDeJardins[0].Solanacees[0];
       // string echalottes = rootObjects[0].TypesDeJardins[4].Litiacees[0];
        Debug.Log(echalottes); // affiche "Echalottes"
    }

    // Update is called once per frame
    void Update()
    {

    }
}
