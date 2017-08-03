using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFunctions : MonoBehaviour {

    public Object sceneDestination;
    private string _strDest;

    private void Awake()
    {
        _strDest = sceneDestination.name;
    }

    public void LoadScene()
    {
        Application.LoadLevel(_strDest);
    }

    static public void LoadScene(Object scene)
    {
        string str = scene.name;
        Application.LoadLevel(str);
    }

}
