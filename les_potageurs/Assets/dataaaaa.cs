using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
public class dataaaaa : MonoBehaviour
{   
    [Serializable]
 
    public class CaracteristiquesLegume
    {
        public float Surface;
        public float ProductionKilo;
        public int Nombre;
    }
    [Serializable]
    // Classe pour stocker un type de l�gume et sa liste de l�gumes
    public class TypeDeLegume
    {
        public string Nom;
        public List<Legume> Legumes;
    }
    [Serializable]
    // Classe pour stocker un l�gume et ses caract�ristiques
    public class Legume
    {
        public string Nom;
        public CaracteristiquesLegume Caracteristiques;
    }
    // ...

    // Cr�er une liste de types de l�gumes
    public List<TypeDeLegume> typesDeLegumes = new List<TypeDeLegume>();

    TypeDeLegume solanacees = new TypeDeLegume()
    {
        Nom = "Solanac�es",
        Legumes = new List<Legume>() {
        new Legume() { Nom = "Tomate", Caracteristiques = new CaracteristiquesLegume() { Surface = 10.5f, ProductionKilo = 25.0f, Nombre = 50 } },
        new Legume() { Nom = "Poivron", Caracteristiques = new CaracteristiquesLegume() { Surface = 8.0f, ProductionKilo = 18.0f, Nombre = 40 } },
        new Legume() { Nom = "Aubergine", Caracteristiques = new CaracteristiquesLegume() { Surface = 6.0f, ProductionKilo = 12.0f, Nombre = 30 } }
    }
    };
    TypeDeLegume verdure = new TypeDeLegume()
    {
        Nom = "Verdures - Racines",
        Legumes = new List<Legume>() {
        new Legume() { Nom = "Laitue", Caracteristiques = new CaracteristiquesLegume() { Surface = 5.5f, ProductionKilo = 10.0f, Nombre = 35 } },
        new Legume() { Nom = "�pinard", Caracteristiques = new CaracteristiquesLegume() { Surface = 4.5f, ProductionKilo = 7.5f, Nombre = 25 } },
        new Legume() { Nom = "M�che", Caracteristiques = new CaracteristiquesLegume() { Surface = 3.0f, ProductionKilo = 6.0f, Nombre = 20 } }
    }
    };
    TypeDeLegume ail = new TypeDeLegume()
    {
        Nom = "Ail-compost",
        Legumes = new List<Legume>() {
        new Legume() { Nom = "Ail blanc", Caracteristiques = new CaracteristiquesLegume() { Surface = 1.5f, ProductionKilo = 4.5f, Nombre = 15 } },
        new Legume() { Nom = "Ail violet", Caracteristiques = new CaracteristiquesLegume() { Surface = 2.0f, ProductionKilo = 5.0f, Nombre = 20 } },
        new Legume() { Nom = "Fraises", Caracteristiques = new CaracteristiquesLegume() { Surface = 1.0f, ProductionKilo = 3.0f, Nombre = 10 } }
    }
    };


    TypeDeLegume Cucurbitacees = new TypeDeLegume()
    {
        Nom = "Cucurbitac�es / Crucif�res / Brassicac�es",
        Legumes = new List<Legume>() {
        new Legume() { Nom = "Artichauts", Caracteristiques = new CaracteristiquesLegume() { Surface = 1.5f, ProductionKilo = 4.5f, Nombre = 15 } },
        new Legume() { Nom = "Brocolis", Caracteristiques = new CaracteristiquesLegume() { Surface = 2.0f, ProductionKilo = 5.0f, Nombre = 20 } },
        new Legume() { Nom = "Courge", Caracteristiques = new CaracteristiquesLegume() { Surface = 1.0f, ProductionKilo = 3.0f, Nombre = 10 } }
    }
    };

    TypeDeLegume Litiacees = new TypeDeLegume()
    {
        Nom = "Litiac�es",
        Legumes = new List<Legume>() {
        new Legume() { Nom = "Ciboulette", Caracteristiques = new CaracteristiquesLegume() { Surface = 1.5f, ProductionKilo = 4.5f, Nombre = 15 } },
        new Legume() { Nom = "C�bette", Caracteristiques = new CaracteristiquesLegume() { Surface = 2.0f, ProductionKilo = 5.0f, Nombre = 20 } },
        new Legume() { Nom = "Echalottes", Caracteristiques = new CaracteristiquesLegume() { Surface = 1.0f, ProductionKilo = 3.0f, Nombre = 10 } }
    }
    };

    // Ajouter les types de l�gumes � la liste de types de l�gumes


    // Start is called before the first frame update
    void Start()
    {

        typesDeLegumes.Add(solanacees);
        typesDeLegumes.Add(verdure);
        typesDeLegumes.Add(ail);
        typesDeLegumes.Add(Cucurbitacees);
        typesDeLegumes.Add(Litiacees);

        /*
         * foreach (Legume legume in solanacees.Legumes)
{
    Debug.Log(legume.Nom);
}*/
    }

    // Update is called once per frame
   
}
