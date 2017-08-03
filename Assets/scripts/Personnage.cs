using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Personnage", order = 1)]
public class Personnage : ScriptableObject
{

    public string Name { get; set; }
    public string Origine { get; set; }
    public string Metier { get; set; }

    public int Courage { get; set; }
    public int Intelligence { get; set; }
    public int Charisme { get; set; }
    public int Adresse { get; set; }
    public int Force { get; set; }

    public Personnage(string name, int cou, int inte, int cha, int adr, int fo)
    {
        Name = name;
        Intelligence = inte;
        Charisme = cha;
        Adresse = adr;
        Force = fo;
    }

    public Personnage(string name)
    {
        Name = name;
    }

}
