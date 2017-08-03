using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class CreateTemporaryPersonnage : MonoBehaviour {

    public Text origine;
    public Text metier;

    //[MenuItem("Assets/Create/Personnage")]
    public static Personnage CreatePersonnage(string name)
    {
        Personnage asset = ScriptableObject.CreateInstance<Personnage>();
        AssetDatabase.CreateAsset(asset, "Assets/Personnages/" + name + ".asset");
        AssetDatabase.SaveAssets();
        return asset;
    }

    public void CreateTmpPersonnage()
    {
        //Personnage perso = (Personnage) AssetDatabase.LoadAssetAtPath("Assets/Personnages/TmpPersonnage.asset", typeof(Personnage));

        Personnage perso;

        if (AssetDatabase.LoadAssetAtPath("Assets/Personnages/TmpPersonnage.asset", typeof(Personnage)) == null)
        {
            perso = CreatePersonnage("TmpPersonnage");
        }
        perso = (Personnage)AssetDatabase.LoadAssetAtPath("Assets/Personnages/TmpPersonnage.asset", typeof(Personnage));
        perso.Origine = origine.text;
        perso.Metier = metier.text;
    }
}
