using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrigineOrMetier : MonoBehaviour {

    public bool isOrigine;

    public void SetOrigineOrMetier(bool isOrigine)
    {
        CharacterInfoScene.DisplayOrigine = isOrigine;
    }

}
