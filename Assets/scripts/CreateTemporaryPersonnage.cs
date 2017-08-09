using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class CreateTemporaryPersonnage : MonoBehaviour {

    public Text origine;
    public Text metier;
    public InputField cou;
    public InputField inte;
    public InputField cha;
    public InputField adr;
    public InputField fo;

    public Personnage CreatePersonnage()
    {
        Personnage asset = ScriptableObject.CreateInstance<Personnage>();
        AssetDatabase.CreateAsset(asset, "Assets/Personnages/TmpPersonnage.asset");
        AssetDatabase.SaveAssets();
        return asset;
    }

    public void CreateTmpPersonnage()
    {
        Personnage perso;
        if (AssetDatabase.LoadAssetAtPath("Assets/Personnages/TmpPersonnage.asset", typeof(Personnage)) == null)
            perso = CreatePersonnage();
        perso = (Personnage) AssetDatabase.LoadAssetAtPath("Assets/Personnages/TmpPersonnage.asset", typeof(Personnage));
        perso.Origine = origine.text;
        perso.Metier = metier.text;
        perso.Courage = int.Parse(cou.text);
        perso.Intelligence = int.Parse(inte.text);
        perso.Charisme = int.Parse(cha.text);
        perso.Adresse = int.Parse(adr.text);
        perso.Force = int.Parse(fo.text);
    }

}
