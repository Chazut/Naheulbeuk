using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSceneOnClick : MonoBehaviour
{
    public Object scene;

    public void ChangeScene()
    {
        string str = scene.name;
        Application.LoadLevel(str);
    }
}
