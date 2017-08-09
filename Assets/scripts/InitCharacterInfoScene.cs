using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class InitCharacterInfoScene : MonoBehaviour {

    public Text title;
    public Button origine;
    public Button magie;
    public Button armure;
    public Button bouclier;
    public Button arme;
    public Button autre;

    private void Awake()
    {
        Personnage perso = (Personnage)AssetDatabase.LoadAssetAtPath("Assets/Personnages/TmpPersonnage.asset", typeof(Personnage));
        if (CharacterInfoScene.DisplayOrigine)
        {
            title.text = perso.Origine.ToUpper();
            if(perso.Origine == "Barbare")
            {
                autre.gameObject.SetActive(false);
            }
        }
        else
        {
            origine.GetComponent<Text>().text = "Métier";
            magie.gameObject.SetActive(false);
            armure.gameObject.SetActive(false);
            bouclier.gameObject.SetActive(false);
            arme.gameObject.SetActive(false);
            autre.gameObject.SetActive(false);
        }
    }

}
