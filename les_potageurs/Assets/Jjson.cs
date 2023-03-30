using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using Newtonsoft.Json;
using UnityEngine.Networking;
using System.IO;

public class Jjson : MonoBehaviour
{

    [Serializable]
    public class Rootobject
    {
        public Class1[] Property1 { get; set; }
    }

    public class Class1
    {
        public Rotation[] Rotation { get; set; }
        public TableauCIBLEOutputDemand�[] TableauCIBLEoutputdemand� { get; set; }
        public Jardin[] Jardins { get; set; }
        public Esp�ces[] Esp�ces { get; set; }
    }

    public class Rotation
    {
        public TypesDeJardin[] Typesdejardins { get; set; }
        public object[] Jardins { get; set; }
    }

    public class TypesDeJardin
    {
        public Solanac�es[] Solanac�es { get; set; }
        public VerduresEtRacine[] Verduresetracines { get; set; }
        public Ail[] Ail { get; set; }
        public Cucurbitac�esCrucif�resBrassicac�es[] Cucurbitac�esCrucif�resBrassicac�es { get; set; }
        public Litiac�es[] Litiac�es { get; set; }
        public TomatesCeris[] Tomatescerises { get; set; }
    }

    public class Solanac�es
    {
        public Aubergine[] Aubergine { get; set; }
        public Piment[] Piment { get; set; }
        public Poivron[] Poivron { get; set; }
        public Tomate[] Tomates { get; set; }
    }

    public class Aubergine
    {
        public LongueBlanche[] Longueblanche { get; set; }
        public Z�brina[] Z�brina { get; set; }
        public DeBarbentane[] DeBarbentane { get; set; }
        public BlackPearlF1[] BlackpearlF1 { get; set; }
    }

    public class LongueBlanche
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Z�brina
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class DeBarbentane
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class BlackPearlF1
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Piment
    {
        public GorriaEspelette[] Gorriaespelette { get; set; }
        public SucetteDeProvence[] SucettedeProvence { get; set; }
    }

    public class GorriaEspelette
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class SucetteDeProvence
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Poivron
    {
        public DiCapriglio[] DiCapriglio { get; set; }
        public OranosF1[] OranosF1 { get; set; }
        public Chocolat[] Chocolat { get; set; }
    }

    public class DiCapriglio
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class OranosF1
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Chocolat
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Tomate
    {
        public CoeurDeBoeufReifRed[] Coeurdeboeufreifred { get; set; }
        public PurpleCalabash[] PurpleCalabash { get; set; }
        public Beaut�Blanche[] Beaut�blanche { get; set; }
        public BrandywineJoyce[] Brandywinejoyce { get; set; }
        public BlackZebra[] BlackZebra { get; set; }
        public GreenZebra[] GreenZebra { get; set; }
        public Verna[] Verna { get; set; }
    }

    public class CoeurDeBoeufReifRed
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class PurpleCalabash
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Beaut�Blanche
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class BrandywineJoyce
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class BlackZebra
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class GreenZebra
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Verna
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class VerduresEtRacine
    {
        public Basilic[] Basilic { get; set; }
        public Betterave[] Betterave { get; set; }
        public BlettePoir�e[] Blettepoir�e { get; set; }
        public Chicor�e[] Chicor�e { get; set; }
        public Carotte[] Carottes { get; set; }
        public C�l�riBranche[] C�l�ribranche { get; set; }
        public Coriandre[] Coriandre { get; set; }
        public Epinard[] Epinards { get; set; }
        public Fenouil[] Fenouil { get; set; }
        public Laitue[] Laitue { get; set; }
        public M�che[] M�che { get; set; }
        public Mesclun[] Mesclun { get; set; }
        public Origan[] Origan { get; set; }
        public Panai[] Panais { get; set; }
        public Persil[] Persil { get; set; }
        public Sariette[] Sariette { get; set; }
        public Scarole[] Scarole { get; set; }
        public Scorsonere[] Scorsonere { get; set; }
        public T�tragone[] T�tragone { get; set; }
    }

    public class Basilic
    {
        public Cannelle[] Cannelle { get; set; }
        public R�glisse[] R�glisse { get; set; }
        public Citron[] Citron { get; set; }
        public Marseillai[] Marseillais { get; set; }
    }

    public class Cannelle
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class R�glisse
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Citron
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Marseillai
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Betterave
    {
        public Chiogga[] Chiogga { get; set; }
    }

    public class Chiogga
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class BlettePoir�e
    {
        public Verte�CardeBlanche[] Verte�Cardeblanche { get; set; }
    }

    public class Verte�CardeBlanche
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Chicor�e
    {
        public Monaco[] Monaco { get; set; }
        public B�n�fine[] B�n�fine { get; set; }
        public RougeDeV�rone[] RougedeV�rone { get; set; }
    }

    public class Monaco
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class B�n�fine
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class RougeDeV�rone
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Carotte
    {
        public WhiteSatin[] Whitesatin { get; set; }
        public Gniff[] Gniff { get; set; }
        public Yellowstone[] Yellowstone { get; set; }
        public NantaiseAm�lior�e[] Nantaiseam�lior�e { get; set; }
    }

    public class WhiteSatin
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Gniff
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Yellowstone
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class NantaiseAm�lior�e
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class C�l�riBranche
    {
        public Tango[] Tango { get; set; }
        public C�l�riRave[] C�l�rirave { get; set; }
    }

    public class Tango
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class C�l�riRave
    {
        public Mar[] Mars { get; set; }
    }

    public class Mar
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Coriandre
    {
        public Caribe[] Caribe { get; set; }
    }

    public class Caribe
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Epinard
    {
        public Matador[] Matador { get; set; }
        public G�antDhiver[] G�antdhiver { get; set; }
        public Ren�gadeF1[] Ren�gadeF1 { get; set; }
        public Baselle[] Baselle { get; set; }
    }

    public class Matador
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class G�antDhiver
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Ren�gadeF1
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Baselle
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Fenouil
    {
        public RondoF1[] RondoF1 { get; set; }
        public SolarisF1[] SolarisF1 { get; set; }
    }

    public class RondoF1
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class SolarisF1
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Laitue
    {
        public LolloRossa[] LolloRossa { get; set; }
        public Gatsby[] Gatsby { get; set; }
    }

    public class LolloRossa
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Gatsby
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class M�che
    {
        public Granon[] Granon { get; set; }
    }

    public class Granon
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Mesclun
    {
        public MesclunsCr�tois[] Mesclunscr�tois { get; set; }
    }

    public class MesclunsCr�tois
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Origan
    {
        public OriganDeSyrie[] OrigandeSyrie { get; set; }
    }

    public class OriganDeSyrie
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Panai
    {
        public DemiLongDeGuernesey[] DemilongdeGuernesey { get; set; }
    }

    public class DemiLongDeGuernesey
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Persil
    {
        public PerillaPourpre[] Perillapourpre { get; set; }
        public Commun[] Commun { get; set; }
    }

    public class PerillaPourpre
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Commun
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Sariette
    {
        public Annuelle[] Annuelle { get; set; }
    }

    public class Annuelle
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Scarole
    {
        public Eliance[] Eliance { get; set; }
        public G�anteMara�ch�re[] G�anteMara�ch�re { get; set; }
    }

    public class Eliance
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class G�anteMara�ch�re
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Scorsonere
    {
        public Enorma[] Enorma { get; set; }
    }

    public class Enorma
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class T�tragone
    {
        public Cornue[] Cornue { get; set; }
    }

    public class Cornue
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Ail
    {
        public Ail1[] _Ail { get; set; }
        public Frais[] Fraises { get; set; }
    }

    public class Ail1
    {
        public Germidour[] Germidour { get; set; }
        public Messidor[] Messidor { get; set; }
    }

    public class Germidour
    {
        public object[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Messidor
    {
        public object[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Frais
    {
        public Charlotte[] Charlotte { get; set; }
    }

    public class Charlotte
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Cucurbitac�esCrucif�resBrassicac�es
    {
        public Artichaut[] Artichauts { get; set; }
    }

    public class Artichaut
    {
        public CynaraCardunculu[] Cynaracardunculus { get; set; }
        public VioletDeProvence[] VioletdeProvence { get; set; }
        public Brocoli[] Brocolis { get; set; }
        public ChouxBruxelle[] Chouxbruxelles { get; set; }
        public ChouFleur[] Choufleur { get; set; }
        public ChouPomm�[] Choupomm� { get; set; }
        public ChouRave[] Chourave { get; set; }
        public Concombre[] Concombre { get; set; }
        public Courge[] Courge { get; set; }
        public Courgette[] Courgette { get; set; }
        public Melon[] Melon { get; set; }
        public Navet[] Navet { get; set; }
        public Past�que[] Past�que { get; set; }
        public P�tisson[] P�tisson { get; set; }
        public Potimarron[] Potimarron { get; set; }
        public Radi[] Radis { get; set; }
        public Roquette[] Roquette { get; set; }
        public Ruthabaga[] Ruthabaga { get; set; }
    }

    public class CynaraCardunculu
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class VioletDeProvence
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Brocoli
    {
        public VioletDuCap[] VioletduCap { get; set; }
        public CovinaF1[] CovinaF1 { get; set; }
    }

    public class VioletDuCap
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class CovinaF1
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class ChouxBruxelle
    {
        public Groninger[] Groninger { get; set; }
    }

    public class Groninger
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class ChouFleur
    {
        public AdonaF1[] AdonaF1 { get; set; }
        public VioletDeSicile[] VioletdeSicile { get; set; }
    }

    public class AdonaF1
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class VioletDeSicile
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class ChouPomm�
    {
        public CaraflexF1[] CaraflexF1 { get; set; }
        public FaraoF1[] FaraoF1 { get; set; }
        public BlancDeVaugirard[] BlancdeVaugirard { get; set; }
    }

    public class CaraflexF1
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class FaraoF1
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class BlancDeVaugirard
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class ChouRave
    {
        public AzurStar[] Azurstar { get; set; }
    }

    public class AzurStar
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Concombre
    {
        public WhiteWonder[] Whitewonder { get; set; }
        public RollinsonsTelegraph[] Rollinsonstelegraph { get; set; }
    }

    public class WhiteWonder
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class RollinsonsTelegraph
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Courge
    {
        public LongueDeNice[] LonguedeNice { get; set; }
        public BabyBoo[] Babyboo { get; set; }
        public Butternut[] Butternut { get; set; }
        public CornueDhiver[] Cornuedhiver { get; set; }
        public Musqu�eDeProvence[] Musqu�edeProvence { get; set; }
    }

    public class LongueDeNice
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class BabyBoo
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Butternut
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class CornueDhiver
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Musqu�eDeProvence
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Courgette
    {
        public Nice�FruitRond[] Nice�fruitrond { get; set; }
        public AlberelloDiSarzana[] AlberellodiSarzana { get; set; }
        public CourgetteJaune[] Courgettejaune { get; set; }
    }

    public class Nice�FruitRond
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class AlberelloDiSarzana
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class CourgetteJaune
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Melon
    {
        public CharantaisSuperPr�coce[] Charantaissuperpr�coce { get; set; }
        public DouceurDeLarc[] DouceurdelArc { get; set; }
    }

    public class CharantaisSuperPr�coce
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class DouceurDeLarc
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Navet
    {
        public Petrowski[] Petrowski { get; set; }
    }

    public class Petrowski
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Past�que
    {
        public SugarBaby[] SugarBaby { get; set; }
    }

    public class SugarBaby
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class P�tisson
    {
        public Blanc[] Blanc { get; set; }
    }

    public class Blanc
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Potimarron
    {
        public Buttercup[] Buttercup { get; set; }
    }

    public class Buttercup
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Radi
    {
        public De18Jours[] De18jours { get; set; }
    }

    public class De18Jours
    {
        public object[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Roquette
    {
        public Cultiv�e[] Cultiv�e { get; set; }
    }

    public class Cultiv�e
    {
        public object[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Ruthabaga
    {
        public Helenor[] Helenor { get; set; }
    }

    public class Helenor
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Litiac�es
    {
        public Echalotte[] Echalottes { get; set; }
        public Oignon[] Oignons { get; set; }
        public Poireau[] Poireau { get; set; }
        public Ciboulette[] Ciboulette { get; set; }
        public C�bette[] C�bette { get; set; }
        public F�ves[] F�ves { get; set; }
        public HaricotFilEtRame[] Haricotfiletrame { get; set; }
        public HaricotsGrain[] Haricotsgrains { get; set; }
        public Pois[] Pois { get; set; }
        public Ma�s[] Ma�s { get; set; }
    }

    public class Echalotte
    {
        public Longor[] Longor { get; set; }
    }

    public class Longor
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Oignon
    {
        public TropeaTonda[] TropeaTonda { get; set; }
    }

    public class TropeaTonda
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Poireau
    {
        public Lancia[] Lancia { get; set; }
        public BleuDeSolaise[] BleudeSolaise { get; set; }
    }

    public class Lancia
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class BleuDeSolaise
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Ciboulette
    {
        public Staro[] Staro { get; set; }
    }

    public class Staro
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class C�bette
    {
        public PasDeVari�t�Indiqu�e[] pasdevari�t�indiqu�e { get; set; }
    }

    public class PasDeVari�t�Indiqu�e
    {
        public object[] Semis { get; set; }
        public object[] Plantation { get; set; }
        public object[] R�colte { get; set; }
    }

    public class F�ves
    {
        public PasDeVari�t�Indiqu�e1[] pasdevari�t�indiqu�e { get; set; }
    }

    public class PasDeVari�t�Indiqu�e1
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class HaricotFilEtRame
    {
        public Vesperale[] Vesperale { get; set; }
        public Blauhilde[] blauhilde { get; set; }
        public Neckargold[] Neckargold { get; set; }
    }

    public class Vesperale
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Blauhilde
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Neckargold
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class HaricotsGrain
    {
        public BigBorlotto[] Bigborlotto { get; set; }
    }

    public class BigBorlotto
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Pois
    {
        public MerveilleDeKelvedon[] MerveilledeKelvedon { get; set; }
    }

    public class MerveilleDeKelvedon
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Ma�s
    {
        public PopcornNoir[] Popcornnoir { get; set; }
    }

    public class PopcornNoir
    {
        public object[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class TomatesCeris
    {
        public MielDuMexique[] MielduMexique { get; set; }
        public Cl�mentine[] Cl�mentine { get; set; }
        public BlackCherry[] BlackCherry { get; set; }
        public GreenGrape[] GreenGrape { get; set; }
    }

    public class MielDuMexique
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Cl�mentine
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class BlackCherry
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class GreenGrape
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class TableauCIBLEOutputDemand�
    {
        public PlancheA[] PlancheA { get; set; }
        public PlancheB[] PlancheB { get; set; }
        public PlancheC[] PlancheC { get; set; }
        public PlancheD[] PlancheD { get; set; }
    }

    public class PlancheA
    {
        public Surface[] surface { get; set; }
        public Zone[] Zones { get; set; }
    }

    public class Surface
    {
        public int[] _2 { get; set; }
    }

    public class Zone
    {
        public _1[] _1 { get; set; }
    }

    public class _1
    {
        public Rang[] Rangs { get; set; }
    }

    public class Rang
    {
        public _11[] _1 { get; set; }
        public _2[] _2 { get; set; }
        public _3[] _3 { get; set; }
        public _4[] _4 { get; set; }
        public _5[] _5 { get; set; }
        public _6[] _6 { get; set; }
    }

    public class _11
    {
        public Surface1[] surface { get; set; }
        public Plante[] plantes { get; set; }
    }

    public class Surface1
    {
        public int[] _2 { get; set; }
    }

    public class Plante
    {
        public Aubergine1[] Aubergine { get; set; }
        public Betterave1[] Betteraves { get; set; }
        public object[] Epinards { get; set; }
        public Pois1[] Pois { get; set; }
        public BlettesPoir�es[] Blettespoir�es { get; set; }
        public object[] Navet { get; set; }
        public F�ves[] F�ves { get; set; }
    }

    public class Aubergine1
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Betterave1
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Pois1
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public float poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class BlettesPoir�es
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class F�ves
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public float poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class _2
    {
        public Surface2[] surface { get; set; }
        public Plante1[] plantes { get; set; }
    }

    public class Surface2
    {
        public int[] _2 { get; set; }
    }

    public class Plante1
    {
        public Fraise[] Fraise { get; set; }
        public Ail2[] Ail { get; set; }
    }

    public class Fraise
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Ail2
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class _3
    {
        public Surface3[] surface { get; set; }
        public Plante2[] plantes { get; set; }
    }

    public class Surface3
    {
        public int[] _2 { get; set; }
    }

    public class Plante2
    {
        public Piment1[] Piments { get; set; }
        public Poivron1[] Poivrons { get; set; }
        public HaricotsFilEtRame[] Haricotsfiletrame { get; set; }
        public Mesclun1[] Mesclun { get; set; }
        public Navet1[] Navet { get; set; }
        public Radi1[] Radis { get; set; }
    }

    public class Piment1
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Poivron1
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class HaricotsFilEtRame
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Mesclun1
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Navet1
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Radi1
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class _4
    {
        public Surface4[] surface { get; set; }
        public Plante3[] plantes { get; set; }
    }

    public class Surface4
    {
        public int[] _2 { get; set; }
    }

    public class Plante3
    {
        public Tomate1[] Tomates { get; set; }
        public Carotte1[] Carottes { get; set; }
        public Oignon1[] Oignons { get; set; }
    }

    public class Tomate1
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Carotte1
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Oignon1
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class _5
    {
        public Surface5[] surface { get; set; }
        public Plante4[] plantes { get; set; }
    }

    public class Surface5
    {
        public int[] _2 { get; set; }
    }

    public class Plante4
    {
        public TomatesCeris1[] Tomatescerises { get; set; }
        public object[] Concombre { get; set; }
        public Roquette1[] Roquette { get; set; }
        public object Pois { get; set; }
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class TomatesCeris1
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Roquette1
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class _6
    {
        public Surface6[] surface { get; set; }
        public Plante5[] plantes { get; set; }
    }

    public class Surface6
    {
        public int[] _2 { get; set; }
    }

    public class Plante5
    {
        public Fraise1[] Fraise { get; set; }
        public Ail3[] Ail { get; set; }
    }

    public class Fraise1
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Ail3
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class PlancheB
    {
        public Surface7[] surface { get; set; }
        public Zone1[] Zones { get; set; }
    }

    public class Surface7
    {
        public int[] _2 { get; set; }
    }

    public class Zone1
    {
        public _12[] _1 { get; set; }
        public _22[] _2 { get; set; }
        public _33[] _3 { get; set; }
    }

    public class _12
    {
        public Rang1[] Rangs { get; set; }
    }

    public class Rang1
    {
        public _13[] _1 { get; set; }
        public _21[] _2 { get; set; }
        public _31[] _3 { get; set; }
        public _41[] _4 { get; set; }
    }

    public class _13
    {
        public Surface8[] surface { get; set; }
        public Plante6[] plantes { get; set; }
    }

    public class Surface8
    {
        public float[] _2 { get; set; }
    }

    public class Plante6
    {
        public Chicor�e1[] Chicor�e { get; set; }
    }

    public class Chicor�e1
    {
        public Monaco1[] Monaco { get; set; }
        public B�n�fine1[] B�n�fine { get; set; }
        public RougeDeV�rone1[] RougedeV�rone { get; set; }
    }

    public class Monaco1
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class B�n�fine1
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class RougeDeV�rone1
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class _21
    {
        public Surface9[] surface { get; set; }
        public Plante7[] plantes { get; set; }
    }

    public class Surface9
    {
        public float[] _2 { get; set; }
    }

    public class Plante7
    {
        public C�l�rieBranche[] C�l�riebranche { get; set; }
        public C�bette1[] C�bette { get; set; }
    }

    public class C�l�rieBranche
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class C�bette1
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class _31
    {
        public Surface10[] surface { get; set; }
        public Plante8[] plantes { get; set; }
    }

    public class Surface10
    {
        public float[] _2 { get; set; }
    }

    public class Plante8
    {
        public C�l�riRave1[] C�l�riRave { get; set; }
        public HaricotsFilEtRame1[] Haricotsfiletrame { get; set; }
        public Roquette2[] Roquette { get; set; }
        public Epinard1[] Epinards { get; set; }
    }

    public class C�l�riRave1
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class HaricotsFilEtRame1
    {
        public float nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public float poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Roquette2
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Epinard1
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public float poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class _41
    {
        public Surface11[] surface { get; set; }
        public Plante9[] plantes { get; set; }
    }

    public class Surface11
    {
        public float[] _2 { get; set; }
    }

    public class Plante9
    {
        public Epinard2[] Epinards { get; set; }
    }

    public class Epinard2
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public float poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class _22
    {
        public _14[] _1 { get; set; }
        public _23[] _2 { get; set; }
        public _32[] _3 { get; set; }
        public _42[] _4 { get; set; }
    }

    public class _14
    {
        public Surface12[] surface { get; set; }
        public Plante10[] plantes { get; set; }
    }

    public class Surface12
    {
        public float[] _2 { get; set; }
    }

    public class Plante10
    {
        public Fraise2[] Fraise { get; set; }
        public Ail4[] Ail { get; set; }
    }

    public class Fraise2
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Ail4
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class _23
    {
        public Surface13[] surface { get; set; }
        public Plante11[] plantes { get; set; }
    }

    public class Surface13
    {
        public float[] _2 { get; set; }
    }

    public class Plante11
    {
        public FenouilRondo[] FenouilRondo { get; set; }
        public Navet2[] Navet { get; set; }
    }

    public class FenouilRondo
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Navet2
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class _32
    {
        public Surface14[] surface { get; set; }
        public Plante12[] plantes { get; set; }
    }

    public class Surface14
    {
        public float[] _2 { get; set; }
    }

    public class Plante12
    {
        public Laitue1[] Laitue { get; set; }
    }

    public class Laitue1
    {
        public LolloRossa1[] LolloRossa { get; set; }
        public Gatsby1[] Gatsby { get; set; }
    }

    public class LolloRossa1
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Gatsby1
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class _42
    {
        public Surface15[] surface { get; set; }
        public Plante13[] plantes { get; set; }
    }

    public class Surface15
    {
        public float[] _2 { get; set; }
    }

    public class Plante13
    {
        public M�che1[] M�che { get; set; }
    }

    public class M�che1
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class _33
    {
        public Surface16[] surface { get; set; }
        public string[] remarques { get; set; }
        public Plante14[] plantes { get; set; }
    }

    public class Surface16
    {
        public int[] _2 { get; set; }
    }

    public class Plante14
    {
        public Kiwi[] Kiwi { get; set; }
    }

    public class Kiwi
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class PlancheC
    {
        public Surface17[] surface { get; set; }
        public Zone2[] Zones { get; set; }
    }

    public class Surface17
    {
        public int[] _2 { get; set; }
    }

    public class Zone2
    {
        public _15[] _1 { get; set; }
    }

    public class _15
    {
        public Rang2[] Rangs { get; set; }
    }

    public class Rang2
    {
        public _16[] _1 { get; set; }
        public _24[] _2 { get; set; }
        public _34[] _3 { get; set; }
        public _43[] _4 { get; set; }
        public _51[] _5 { get; set; }
    }

    public class _16
    {
        public Surface18[] surface { get; set; }
        public Plante15[] plantes { get; set; }
    }

    public class Surface18
    {
        public float[] _2 { get; set; }
    }

    public class Plante15
    {
        public Tomate2[] Tomates { get; set; }
        public Panai1[] Panais { get; set; }
        public Mesclun2[] Mesclun { get; set; }
    }

    public class Tomate2
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Panai1
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Mesclun2
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class _24
    {
        public Surface19[] surface { get; set; }
        public Plante16[] plantes { get; set; }
    }

    public class Surface19
    {
        public float[] _2 { get; set; }
    }

    public class Plante16
    {
        public TomatesCeris2[] Tomatescerises { get; set; }
        public T�tragone1[] T�tragone { get; set; }
        public F�ves1[] F�ves { get; set; }
    }

    public class TomatesCeris2
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class T�tragone1
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public float poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class F�ves1
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class _34
    {
        public Surface20[] surface { get; set; }
        public Plante17[] plantes { get; set; }
    }

    public class Surface20
    {
        public float[] _2 { get; set; }
    }

    public class Plante17
    {
        public Courge1[] Courge { get; set; }
        public Mai[] Mais { get; set; }
        public F�ves2[] F�ves { get; set; }
        public Radi2[] Radis { get; set; }
    }

    public class Courge1
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Mai
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class F�ves2
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Radi2
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class _43
    {
        public Surface21[] surface { get; set; }
        public Plante18[] plantes { get; set; }
    }

    public class Surface21
    {
        public float[] _2 { get; set; }
    }

    public class Plante18
    {
        public Brocoli1[] Brocolis { get; set; }
        public HaricotsBorlotto[] Haricotsborlotto { get; set; }
        public Radi3[] Radis { get; set; }
    }

    public class Brocoli1
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class HaricotsBorlotto
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public float poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Radi3
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class _51
    {
        public Surface22[] surface { get; set; }
        public Plante19[] plantes { get; set; }
    }

    public class Surface22
    {
        public float[] _2 { get; set; }
    }

    public class Plante19
    {
        public ChouFleur1[] Choufleurs { get; set; }
        public Oignon2[] Oignons { get; set; }
        public Epinard3[] Epinards { get; set; }
    }

    public class ChouFleur1
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Oignon2
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Epinard3
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public float poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class PlancheD
    {
        public Surface23[] surface { get; set; }
    }

    public class Surface23
    {
        public float[] _2 { get; set; }
        public Zone3[] Zones { get; set; }
    }

    public class Zone3
    {
        public _17[] _1 { get; set; }
    }

    public class _17
    {
        public Rang3[] Rangs { get; set; }
    }

    public class Rang3
    {
        public _18[] _1 { get; set; }
        public _25[] _2 { get; set; }
        public _35[] _3 { get; set; }
        public _44[] _4 { get; set; }
        public _52[] _5 { get; set; }
        public _61[] _6 { get; set; }
        public _7[] _7 { get; set; }
    }

    public class _18
    {
        public ChouRave1[] Chourave { get; set; }
        public Concombre1[] Concombre { get; set; }
        public Ail5[] Ail { get; set; }
    }

    public class ChouRave1
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Concombre1
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public float poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Ail5
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class _25
    {
        public HaricotsBorlotto1[] Haricotsborlotto { get; set; }
        public Courgette1[] Courgette { get; set; }
        public Epinard4[] Epinards { get; set; }
    }

    public class HaricotsBorlotto1
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Courgette1
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Epinard4
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class _35
    {
        public P�tisson1[] P�tisson { get; set; }
        public HaricotsFilEtRame2[] Haricotsfiletrame { get; set; }
        public Epinard5[] Epinards { get; set; }
    }

    public class P�tisson1
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class HaricotsFilEtRame2
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Epinard5
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class _44
    {
        public Tomate3[] Tomates { get; set; }
        public Carotte2[] Carottes { get; set; }
        public Oignon3[] Oignon { get; set; }
    }

    public class Tomate3
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public string[] R�colte { get; set; }
    }

    public class Carotte2
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Oignon3
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class _52
    {
        public TomatesCeris3[] Tomatescerises { get; set; }
        public T�tragone2[] T�tragone { get; set; }
        public F�ves3[] F�ves { get; set; }
        public Epinard6[] Epinards { get; set; }
    }

    public class TomatesCeris3
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class T�tragone2
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class F�ves3
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public float poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Epinard6
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class _61
    {
        public Frais1[] Fraises { get; set; }
        public Ail6[] Ail { get; set; }
    }

    public class Frais1
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Ail6
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class _7
    {
        public HaricotsBorlotto2[] Haricotsborlotto { get; set; }
        public Courgette2[] Courgette { get; set; }
        public Epinard7[] Epinards { get; set; }
    }

    public class HaricotsBorlotto2
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Courgette2
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Epinard7
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Jardin
    {
        public string[] Jardin1 { get; set; }
        public string[] Jardin2 { get; set; }
        public string[] Jardin3 { get; set; }
        public string[] Jardin4 { get; set; }
        public string[] Jardin5 { get; set; }
    }

    public class Esp�ces
    {
        public Esp�ceBlacklist�es[] Esp�ceblacklist�es { get; set; }
        public Esp�cesNonDocument�es[] Esp�cesnondocument�es { get; set; }
        public Esp�cesDocument�es[] Esp�cesdocument�es { get; set; }
        public UserSelection[] UserSelection { get; set; }
    }

    public class Esp�ceBlacklist�es
    {
        public string[] Basilic { get; set; }
    }

    public class Esp�cesNonDocument�es
    {
        public string[] Amarante { get; set; }
        public string[] Aneth { get; set; }
        public string[] Arroche { get; set; }
        public string[] Asperge { get; set; }
        public string[] Blette { get; set; }
        public string[] Brocolis { get; set; }
        public string[] Cardons { get; set; }
        public string[] Cerfeuil { get; set; }
        public string[] Ciboule { get; set; }
        public string[] Cresson { get; set; }
        public string[] Lavande { get; set; }
        public string[] Lentille { get; set; }
        public string[] Liv�che { get; set; }
        public string[] Ma�s { get; set; }
        public string[] Marjolaine { get; set; }
        public string[] M�lisse { get; set; }
        public string[] Menthe { get; set; }
        public string[] Oseille { get; set; }
        public string[] Poischiche { get; set; }
        public string[] Romarin { get; set; }
        public string[] Rhubarbe { get; set; }
        public string[] Sauge { get; set; }
    }

    public class Esp�cesDocument�es
    {
        public string[] Compost { get; set; }
    }

    public class UserSelection
    {
        public Aubergine2[] Aubergine { get; set; }
        public Betterave2[] Betteraves { get; set; }
        public object[] Epinards { get; set; }
        public Pois2[] Pois { get; set; }
        public BlettesPoir�es1[] Blettespoir�es { get; set; }
        public object[] Navet { get; set; }
        public F�ves300Items151125KgParAn[] F�ves300items151125Kgparan { get; set; }
        public Fraise3[] Fraise { get; set; }
        public Ail7[] Ail { get; set; }
        public Piment2[] Piments { get; set; }
        public Poivron2[] Poivrons { get; set; }
        public HaricotsFilEtRame3[] Haricotsfiletrame { get; set; }
        public Mesclun3[] Mesclun { get; set; }
        public Radi4[] Radis { get; set; }
        public Tomate4[] Tomates { get; set; }
        public Carotte3[] Carottes { get; set; }
        public Oignon4[] Oignons { get; set; }
        public TomatesCeris4[] Tomatescerises { get; set; }
        public object[] Concombre { get; set; }
        public Roquette3[] Roquette { get; set; }
        public Chicor�e2[] Chicor�e { get; set; }
        public C�l�rieBranche1[] C�l�riebranche { get; set; }
        public C�bette2[] C�bette { get; set; }
        public C�l�riRave2[] C�l�riRave { get; set; }
        public FenouilRondo1[] FenouilRondo { get; set; }
        public Laitue2[] Laitue { get; set; }
        public M�che2[] M�che { get; set; }
        public Kiwi1[] Kiwi { get; set; }
        public Panai2[] Panais { get; set; }
        public T�tragone3[] T�tragone { get; set; }
        public F�ves4[] F�ves { get; set; }
        public Courge2[] Courge { get; set; }
        public Mai1[] Mais { get; set; }
        public Brocoli2[] Brocolis { get; set; }
        public HaricotsBorlotto3[] Haricotsborlotto { get; set; }
        public ChouFleur2[] Choufleurs { get; set; }
        public ChouRave2[] Chourave { get; set; }
        public Courgette3[] Courgette { get; set; }
        public P�tisson2[] P�tisson { get; set; }
        public Oignon5[] Oignon { get; set; }
        public Frais2[] Fraises { get; set; }
    }

    public class Aubergine2
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Betterave2
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Pois2
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public float poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class BlettesPoir�es1
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class F�ves300Items151125KgParAn
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public float poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Fraise3
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Ail7
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Piment2
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Poivron2
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class HaricotsFilEtRame3
    {
        public float nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public float poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Mesclun3
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Radi4
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Tomate4
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public object[] R�colte { get; set; }
    }

    public class Carotte3
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Oignon4
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class TomatesCeris4
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Roquette3
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Chicor�e2
    {
        public Monaco2[] Monaco { get; set; }
        public B�n�fine2[] B�n�fine { get; set; }
        public RougeDeV�rone2[] RougedeV�rone { get; set; }
    }

    public class Monaco2
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class B�n�fine2
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class RougeDeV�rone2
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class C�l�rieBranche1
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class C�bette2
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class C�l�riRave2
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class FenouilRondo1
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Laitue2
    {
        public LolloRossa2[] LolloRossa { get; set; }
        public Gatsby2[] Gatsby { get; set; }
    }

    public class LolloRossa2
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Gatsby2
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class M�che2
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Kiwi1
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Panai2
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class T�tragone3
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public float poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class F�ves4
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public float poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Courge2
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Mai1
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Brocoli2
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class HaricotsBorlotto3
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public float poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class ChouFleur2
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class ChouRave2
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Courgette3
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class P�tisson2
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Oignon5
    {
        public int nombre { get; set; }
        public float surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }

    public class Frais2
    {
        public int nombre { get; set; }
        public int surfacetotalen�cessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] R�colte { get; set; }
    }








    void Start()
    {
        // Rootobject response = JsonConvert.DeserializeObject<Rootobject>();

        /*
         * 
         * ClassOpenWeatherMap.Parent response = JsonConvert.DeserializeObject<ClassOpenWeatherMap.Parent>(resultRequest);

                infoAssignation.AssignChangeInfo(response);

                Create_URL_Ico(infoAssignation.Ico);
           */



        // Chemin d'acc�s complet du fichier JSON dans la fen�tre de projet
        string jsonFilePath = Application.dataPath + "/Path/To/Your/dataHack.json";

        // Ouvrir le fichier JSON et le lire en tant que cha�ne


        // string jsonString = reader.ReadToEnd();

        // D�s�rialiser la cha�ne JSON en un objet Rootobject
        Rootobject[] response = JsonConvert.DeserializeObject<Rootobject[]>(jsonFilePath);
        /*
            Debug.Log(response.Property1[0].Rotation[0].Jardins[0]);
            Debug.Log(response.Property1[0].Jardins[0].Jardin1);
            Debug.Log(response.Property1[0].Jardins[0].Jardin2);
        */

       // Debug.Log(response[0].Property1[0].Jardins);

      



    }

}
