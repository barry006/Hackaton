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
        public TableauCIBLEOutputDemandé[] TableauCIBLEoutputdemandé { get; set; }
        public Jardin[] Jardins { get; set; }
        public Espèces[] Espèces { get; set; }
    }

    public class Rotation
    {
        public TypesDeJardin[] Typesdejardins { get; set; }
        public object[] Jardins { get; set; }
    }

    public class TypesDeJardin
    {
        public Solanacées[] Solanacées { get; set; }
        public VerduresEtRacine[] Verduresetracines { get; set; }
        public Ail[] Ail { get; set; }
        public CucurbitacéesCrucifèresBrassicacées[] CucurbitacéesCrucifèresBrassicacées { get; set; }
        public Litiacées[] Litiacées { get; set; }
        public TomatesCeris[] Tomatescerises { get; set; }
    }

    public class Solanacées
    {
        public Aubergine[] Aubergine { get; set; }
        public Piment[] Piment { get; set; }
        public Poivron[] Poivron { get; set; }
        public Tomate[] Tomates { get; set; }
    }

    public class Aubergine
    {
        public LongueBlanche[] Longueblanche { get; set; }
        public Zébrina[] Zébrina { get; set; }
        public DeBarbentane[] DeBarbentane { get; set; }
        public BlackPearlF1[] BlackpearlF1 { get; set; }
    }

    public class LongueBlanche
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Zébrina
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class DeBarbentane
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class BlackPearlF1
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
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
        public int[] Récolte { get; set; }
    }

    public class SucetteDeProvence
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
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
        public int[] Récolte { get; set; }
    }

    public class OranosF1
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Chocolat
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Tomate
    {
        public CoeurDeBoeufReifRed[] Coeurdeboeufreifred { get; set; }
        public PurpleCalabash[] PurpleCalabash { get; set; }
        public BeautéBlanche[] Beautéblanche { get; set; }
        public BrandywineJoyce[] Brandywinejoyce { get; set; }
        public BlackZebra[] BlackZebra { get; set; }
        public GreenZebra[] GreenZebra { get; set; }
        public Verna[] Verna { get; set; }
    }

    public class CoeurDeBoeufReifRed
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class PurpleCalabash
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class BeautéBlanche
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class BrandywineJoyce
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class BlackZebra
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class GreenZebra
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Verna
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class VerduresEtRacine
    {
        public Basilic[] Basilic { get; set; }
        public Betterave[] Betterave { get; set; }
        public BlettePoirée[] Blettepoirée { get; set; }
        public Chicorée[] Chicorée { get; set; }
        public Carotte[] Carottes { get; set; }
        public CélériBranche[] Céléribranche { get; set; }
        public Coriandre[] Coriandre { get; set; }
        public Epinard[] Epinards { get; set; }
        public Fenouil[] Fenouil { get; set; }
        public Laitue[] Laitue { get; set; }
        public Mâche[] Mâche { get; set; }
        public Mesclun[] Mesclun { get; set; }
        public Origan[] Origan { get; set; }
        public Panai[] Panais { get; set; }
        public Persil[] Persil { get; set; }
        public Sariette[] Sariette { get; set; }
        public Scarole[] Scarole { get; set; }
        public Scorsonere[] Scorsonere { get; set; }
        public Tétragone[] Tétragone { get; set; }
    }

    public class Basilic
    {
        public Cannelle[] Cannelle { get; set; }
        public Réglisse[] Réglisse { get; set; }
        public Citron[] Citron { get; set; }
        public Marseillai[] Marseillais { get; set; }
    }

    public class Cannelle
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Réglisse
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Citron
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Marseillai
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Betterave
    {
        public Chiogga[] Chiogga { get; set; }
    }

    public class Chiogga
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class BlettePoirée
    {
        public VerteÀCardeBlanche[] VerteàCardeblanche { get; set; }
    }

    public class VerteÀCardeBlanche
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Chicorée
    {
        public Monaco[] Monaco { get; set; }
        public Bénéfine[] Bénéfine { get; set; }
        public RougeDeVérone[] RougedeVérone { get; set; }
    }

    public class Monaco
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Bénéfine
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class RougeDeVérone
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Carotte
    {
        public WhiteSatin[] Whitesatin { get; set; }
        public Gniff[] Gniff { get; set; }
        public Yellowstone[] Yellowstone { get; set; }
        public NantaiseAméliorée[] Nantaiseaméliorée { get; set; }
    }

    public class WhiteSatin
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Gniff
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Yellowstone
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class NantaiseAméliorée
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class CélériBranche
    {
        public Tango[] Tango { get; set; }
        public CélériRave[] Célérirave { get; set; }
    }

    public class Tango
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class CélériRave
    {
        public Mar[] Mars { get; set; }
    }

    public class Mar
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Coriandre
    {
        public Caribe[] Caribe { get; set; }
    }

    public class Caribe
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Epinard
    {
        public Matador[] Matador { get; set; }
        public GéantDhiver[] Géantdhiver { get; set; }
        public RenégadeF1[] RenégadeF1 { get; set; }
        public Baselle[] Baselle { get; set; }
    }

    public class Matador
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class GéantDhiver
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class RenégadeF1
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Baselle
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
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
        public int[] Récolte { get; set; }
    }

    public class SolarisF1
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
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
        public int[] Récolte { get; set; }
    }

    public class Gatsby
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Mâche
    {
        public Granon[] Granon { get; set; }
    }

    public class Granon
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Mesclun
    {
        public MesclunsCrétois[] Mesclunscrétois { get; set; }
    }

    public class MesclunsCrétois
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Origan
    {
        public OriganDeSyrie[] OrigandeSyrie { get; set; }
    }

    public class OriganDeSyrie
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Panai
    {
        public DemiLongDeGuernesey[] DemilongdeGuernesey { get; set; }
    }

    public class DemiLongDeGuernesey
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
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
        public int[] Récolte { get; set; }
    }

    public class Commun
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Sariette
    {
        public Annuelle[] Annuelle { get; set; }
    }

    public class Annuelle
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Scarole
    {
        public Eliance[] Eliance { get; set; }
        public GéanteMaraîchère[] GéanteMaraîchère { get; set; }
    }

    public class Eliance
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class GéanteMaraîchère
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Scorsonere
    {
        public Enorma[] Enorma { get; set; }
    }

    public class Enorma
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Tétragone
    {
        public Cornue[] Cornue { get; set; }
    }

    public class Cornue
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
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
        public int[] Récolte { get; set; }
    }

    public class Messidor
    {
        public object[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Frais
    {
        public Charlotte[] Charlotte { get; set; }
    }

    public class Charlotte
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class CucurbitacéesCrucifèresBrassicacées
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
        public ChouPommé[] Choupommé { get; set; }
        public ChouRave[] Chourave { get; set; }
        public Concombre[] Concombre { get; set; }
        public Courge[] Courge { get; set; }
        public Courgette[] Courgette { get; set; }
        public Melon[] Melon { get; set; }
        public Navet[] Navet { get; set; }
        public Pastèque[] Pastèque { get; set; }
        public Pâtisson[] Pâtisson { get; set; }
        public Potimarron[] Potimarron { get; set; }
        public Radi[] Radis { get; set; }
        public Roquette[] Roquette { get; set; }
        public Ruthabaga[] Ruthabaga { get; set; }
    }

    public class CynaraCardunculu
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class VioletDeProvence
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
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
        public int[] Récolte { get; set; }
    }

    public class CovinaF1
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class ChouxBruxelle
    {
        public Groninger[] Groninger { get; set; }
    }

    public class Groninger
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
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
        public int[] Récolte { get; set; }
    }

    public class VioletDeSicile
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class ChouPommé
    {
        public CaraflexF1[] CaraflexF1 { get; set; }
        public FaraoF1[] FaraoF1 { get; set; }
        public BlancDeVaugirard[] BlancdeVaugirard { get; set; }
    }

    public class CaraflexF1
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class FaraoF1
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class BlancDeVaugirard
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class ChouRave
    {
        public AzurStar[] Azurstar { get; set; }
    }

    public class AzurStar
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
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
        public int[] Récolte { get; set; }
    }

    public class RollinsonsTelegraph
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Courge
    {
        public LongueDeNice[] LonguedeNice { get; set; }
        public BabyBoo[] Babyboo { get; set; }
        public Butternut[] Butternut { get; set; }
        public CornueDhiver[] Cornuedhiver { get; set; }
        public MusquéeDeProvence[] MusquéedeProvence { get; set; }
    }

    public class LongueDeNice
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class BabyBoo
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Butternut
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class CornueDhiver
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class MusquéeDeProvence
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Courgette
    {
        public NiceÀFruitRond[] Niceàfruitrond { get; set; }
        public AlberelloDiSarzana[] AlberellodiSarzana { get; set; }
        public CourgetteJaune[] Courgettejaune { get; set; }
    }

    public class NiceÀFruitRond
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class AlberelloDiSarzana
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class CourgetteJaune
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Melon
    {
        public CharantaisSuperPrécoce[] Charantaissuperprécoce { get; set; }
        public DouceurDeLarc[] DouceurdelArc { get; set; }
    }

    public class CharantaisSuperPrécoce
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class DouceurDeLarc
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Navet
    {
        public Petrowski[] Petrowski { get; set; }
    }

    public class Petrowski
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Pastèque
    {
        public SugarBaby[] SugarBaby { get; set; }
    }

    public class SugarBaby
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Pâtisson
    {
        public Blanc[] Blanc { get; set; }
    }

    public class Blanc
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Potimarron
    {
        public Buttercup[] Buttercup { get; set; }
    }

    public class Buttercup
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Radi
    {
        public De18Jours[] De18jours { get; set; }
    }

    public class De18Jours
    {
        public object[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Roquette
    {
        public Cultivée[] Cultivée { get; set; }
    }

    public class Cultivée
    {
        public object[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Ruthabaga
    {
        public Helenor[] Helenor { get; set; }
    }

    public class Helenor
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Litiacées
    {
        public Echalotte[] Echalottes { get; set; }
        public Oignon[] Oignons { get; set; }
        public Poireau[] Poireau { get; set; }
        public Ciboulette[] Ciboulette { get; set; }
        public Cébette[] Cébette { get; set; }
        public Fêves[] Fêves { get; set; }
        public HaricotFilEtRame[] Haricotfiletrame { get; set; }
        public HaricotsGrain[] Haricotsgrains { get; set; }
        public Pois[] Pois { get; set; }
        public Maïs[] Maïs { get; set; }
    }

    public class Echalotte
    {
        public Longor[] Longor { get; set; }
    }

    public class Longor
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Oignon
    {
        public TropeaTonda[] TropeaTonda { get; set; }
    }

    public class TropeaTonda
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
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
        public int[] Récolte { get; set; }
    }

    public class BleuDeSolaise
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Ciboulette
    {
        public Staro[] Staro { get; set; }
    }

    public class Staro
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Cébette
    {
        public PasDeVariétéIndiquée[] pasdevariétéindiquée { get; set; }
    }

    public class PasDeVariétéIndiquée
    {
        public object[] Semis { get; set; }
        public object[] Plantation { get; set; }
        public object[] Récolte { get; set; }
    }

    public class Fêves
    {
        public PasDeVariétéIndiquée1[] pasdevariétéindiquée { get; set; }
    }

    public class PasDeVariétéIndiquée1
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
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
        public int[] Récolte { get; set; }
    }

    public class Blauhilde
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Neckargold
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class HaricotsGrain
    {
        public BigBorlotto[] Bigborlotto { get; set; }
    }

    public class BigBorlotto
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Pois
    {
        public MerveilleDeKelvedon[] MerveilledeKelvedon { get; set; }
    }

    public class MerveilleDeKelvedon
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Maïs
    {
        public PopcornNoir[] Popcornnoir { get; set; }
    }

    public class PopcornNoir
    {
        public object[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class TomatesCeris
    {
        public MielDuMexique[] MielduMexique { get; set; }
        public Clémentine[] Clémentine { get; set; }
        public BlackCherry[] BlackCherry { get; set; }
        public GreenGrape[] GreenGrape { get; set; }
    }

    public class MielDuMexique
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Clémentine
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class BlackCherry
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class GreenGrape
    {
        public int[] Semis { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class TableauCIBLEOutputDemandé
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
        public BlettesPoirées[] Blettespoirées { get; set; }
        public object[] Navet { get; set; }
        public Fèves[] Fèves { get; set; }
    }

    public class Aubergine1
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Betterave1
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Pois1
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public float poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class BlettesPoirées
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Fèves
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public float poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
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
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Ail2
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
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
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Poivron1
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class HaricotsFilEtRame
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Mesclun1
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Navet1
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Radi1
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
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
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Carotte1
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Oignon1
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
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
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class TomatesCeris1
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Roquette1
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
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
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Ail3
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
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
        public Chicorée1[] Chicorée { get; set; }
    }

    public class Chicorée1
    {
        public Monaco1[] Monaco { get; set; }
        public Bénéfine1[] Bénéfine { get; set; }
        public RougeDeVérone1[] RougedeVérone { get; set; }
    }

    public class Monaco1
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Bénéfine1
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class RougeDeVérone1
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
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
        public CélérieBranche[] Célériebranche { get; set; }
        public Cébette1[] Cébette { get; set; }
    }

    public class CélérieBranche
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Cébette1
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
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
        public CélériRave1[] CélériRave { get; set; }
        public HaricotsFilEtRame1[] Haricotsfiletrame { get; set; }
        public Roquette2[] Roquette { get; set; }
        public Epinard1[] Epinards { get; set; }
    }

    public class CélériRave1
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class HaricotsFilEtRame1
    {
        public float nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public float poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Roquette2
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Epinard1
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public float poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
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
        public float surfacetotalenécessaire { get; set; }
        public float poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
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
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Ail4
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
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
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Navet2
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
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
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Gatsby1
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
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
        public Mâche1[] Mâche { get; set; }
    }

    public class Mâche1
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
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
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
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
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Panai1
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Mesclun2
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
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
        public Tétragone1[] Tétragone { get; set; }
        public Fèves1[] Fèves { get; set; }
    }

    public class TomatesCeris2
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Tétragone1
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public float poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Fèves1
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
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
        public Fèves2[] Fèves { get; set; }
        public Radi2[] Radis { get; set; }
    }

    public class Courge1
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Mai
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Fèves2
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Radi2
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
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
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class HaricotsBorlotto
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public float poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Radi3
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
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
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Oignon2
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Epinard3
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public float poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
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
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Concombre1
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public float poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Ail5
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
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
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Courgette1
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Epinard4
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class _35
    {
        public Pâtisson1[] Pâtisson { get; set; }
        public HaricotsFilEtRame2[] Haricotsfiletrame { get; set; }
        public Epinard5[] Epinards { get; set; }
    }

    public class Pâtisson1
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class HaricotsFilEtRame2
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Epinard5
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
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
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public string[] Récolte { get; set; }
    }

    public class Carotte2
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Oignon3
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class _52
    {
        public TomatesCeris3[] Tomatescerises { get; set; }
        public Tétragone2[] Tétragone { get; set; }
        public Fèves3[] Fèves { get; set; }
        public Epinard6[] Epinards { get; set; }
    }

    public class TomatesCeris3
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Tétragone2
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Fèves3
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public float poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Epinard6
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class _61
    {
        public Frais1[] Fraises { get; set; }
        public Ail6[] Ail { get; set; }
    }

    public class Frais1
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Ail6
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
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
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Courgette2
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Epinard7
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Jardin
    {
        public string[] Jardin1 { get; set; }
        public string[] Jardin2 { get; set; }
        public string[] Jardin3 { get; set; }
        public string[] Jardin4 { get; set; }
        public string[] Jardin5 { get; set; }
    }

    public class Espèces
    {
        public EspèceBlacklistées[] Espèceblacklistées { get; set; }
        public EspècesNonDocumentées[] Espècesnondocumentées { get; set; }
        public EspècesDocumentées[] Espècesdocumentées { get; set; }
        public UserSelection[] UserSelection { get; set; }
    }

    public class EspèceBlacklistées
    {
        public string[] Basilic { get; set; }
    }

    public class EspècesNonDocumentées
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
        public string[] Livèche { get; set; }
        public string[] Maïs { get; set; }
        public string[] Marjolaine { get; set; }
        public string[] Mélisse { get; set; }
        public string[] Menthe { get; set; }
        public string[] Oseille { get; set; }
        public string[] Poischiche { get; set; }
        public string[] Romarin { get; set; }
        public string[] Rhubarbe { get; set; }
        public string[] Sauge { get; set; }
    }

    public class EspècesDocumentées
    {
        public string[] Compost { get; set; }
    }

    public class UserSelection
    {
        public Aubergine2[] Aubergine { get; set; }
        public Betterave2[] Betteraves { get; set; }
        public object[] Epinards { get; set; }
        public Pois2[] Pois { get; set; }
        public BlettesPoirées1[] Blettespoirées { get; set; }
        public object[] Navet { get; set; }
        public Fèves300Items151125KgParAn[] Fèves300items151125Kgparan { get; set; }
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
        public Chicorée2[] Chicorée { get; set; }
        public CélérieBranche1[] Célériebranche { get; set; }
        public Cébette2[] Cébette { get; set; }
        public CélériRave2[] CélériRave { get; set; }
        public FenouilRondo1[] FenouilRondo { get; set; }
        public Laitue2[] Laitue { get; set; }
        public Mâche2[] Mâche { get; set; }
        public Kiwi1[] Kiwi { get; set; }
        public Panai2[] Panais { get; set; }
        public Tétragone3[] Tétragone { get; set; }
        public Fèves4[] Fèves { get; set; }
        public Courge2[] Courge { get; set; }
        public Mai1[] Mais { get; set; }
        public Brocoli2[] Brocolis { get; set; }
        public HaricotsBorlotto3[] Haricotsborlotto { get; set; }
        public ChouFleur2[] Choufleurs { get; set; }
        public ChouRave2[] Chourave { get; set; }
        public Courgette3[] Courgette { get; set; }
        public Pâtisson2[] Pâtisson { get; set; }
        public Oignon5[] Oignon { get; set; }
        public Frais2[] Fraises { get; set; }
    }

    public class Aubergine2
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Betterave2
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Pois2
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public float poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class BlettesPoirées1
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Fèves300Items151125KgParAn
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public float poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Fraise3
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Ail7
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Piment2
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Poivron2
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class HaricotsFilEtRame3
    {
        public float nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public float poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Mesclun3
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Radi4
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Tomate4
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public object[] Récolte { get; set; }
    }

    public class Carotte3
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Oignon4
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class TomatesCeris4
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Roquette3
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Chicorée2
    {
        public Monaco2[] Monaco { get; set; }
        public Bénéfine2[] Bénéfine { get; set; }
        public RougeDeVérone2[] RougedeVérone { get; set; }
    }

    public class Monaco2
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Bénéfine2
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class RougeDeVérone2
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class CélérieBranche1
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Cébette2
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class CélériRave2
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class FenouilRondo1
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Laitue2
    {
        public LolloRossa2[] LolloRossa { get; set; }
        public Gatsby2[] Gatsby { get; set; }
    }

    public class LolloRossa2
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Gatsby2
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Mâche2
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Kiwi1
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Panai2
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Tétragone3
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public float poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Fèves4
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public float poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Courge2
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Mai1
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Brocoli2
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class HaricotsBorlotto3
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public float poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class ChouFleur2
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class ChouRave2
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Courgette3
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Pâtisson2
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Oignon5
    {
        public int nombre { get; set; }
        public float surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
    }

    public class Frais2
    {
        public int nombre { get; set; }
        public int surfacetotalenécessaire { get; set; }
        public int poidstotal { get; set; }
        public int[] Plantation { get; set; }
        public int[] Récolte { get; set; }
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



        // Chemin d'accès complet du fichier JSON dans la fenêtre de projet
        string jsonFilePath = Application.dataPath + "/Path/To/Your/dataHack.json";

        // Ouvrir le fichier JSON et le lire en tant que chaîne


        // string jsonString = reader.ReadToEnd();

        // Désérialiser la chaîne JSON en un objet Rootobject
        Rootobject[] response = JsonConvert.DeserializeObject<Rootobject[]>(jsonFilePath);
        /*
            Debug.Log(response.Property1[0].Rotation[0].Jardins[0]);
            Debug.Log(response.Property1[0].Jardins[0].Jardin1);
            Debug.Log(response.Property1[0].Jardins[0].Jardin2);
        */

       // Debug.Log(response[0].Property1[0].Jardins);

      



    }

}
