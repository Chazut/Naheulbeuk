using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personnage : ScriptableObject {

    public string Name { get; set; }
    public string Origine { get; set; }
    public string Metier { get; set; }

    public int Courage { get; set; }
    public int Intelligence { get; set; }
    public int Charisme { get; set; }
    public int Adresse { get; set; }
    public int Force { get; set; }

}
