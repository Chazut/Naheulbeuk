using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateMetier : MonoBehaviour {

    public InputField inputCourage;
    public InputField inputIntelligence;
    public InputField inputCharisme;
    public InputField inputAdresse;
    public InputField inputForce;

    private int _courage = -1;
    private int _intelligence = -1;
    private int _charisme = -1;
    private int _adresse = -1;
    private int _force = -1;

    private string _metier;

    public void Maj()
    {
        if (inputCourage.text != null && inputCourage.text != "")
        {
            _courage = int.Parse(inputCourage.text);
        }
        else
        {
            _courage = -1;
        }
        if (inputIntelligence.text != null && inputIntelligence.text != "")
        {
            _intelligence = int.Parse(inputIntelligence.text);
        }
        else
        {
            _intelligence = -1;
        }
        if (inputCharisme.text != null && inputCharisme.text != "")
        {
            _charisme = int.Parse(inputCharisme.text);
        }
        else
        {
            _charisme = -1;
        }
        if (inputAdresse.text != null && inputAdresse.text != "")
        {
            _adresse = int.Parse(inputAdresse.text);
        }
        else
        {
            _adresse = -1;
        }
        if (inputForce.text != null && inputForce.text != "")
        {
            _force = int.Parse(inputForce.text);
        }
        else
        {
            _force = -1;
        }

        _metier = transform.GetChild(0).GetComponent<Text>().text;
        switch (_metier)
        {
            case "Rien":
                if (_courage != -1 || _intelligence != -1 || _charisme != -1 || _adresse != -1 || _force != -1)
                {
                    GetComponent<Image>().color = new Color(0, 1, 0, 0.35f);
                }
                else
                {
                    GetComponent<Image>().color = Color.white;
                }
                break;
            case "Guerrier":
                if (_courage != -1 && _force != -1)
                {
                    if (_courage >= 12 && _force >= 12)
                    {
                        GetComponent<Image>().color = new Color(0, 1, 0, 0.35f);
                    }
                    else
                    {
                        GetComponent<Image>().color = new Color(1, 1, 1, 0.35f);
                    }
                }
                else
                {
                    GetComponent<Image>().color = Color.white;
                }
                break;
            case "Assassin":
                if (_adresse != -1)
                {
                    if (_adresse >= 13)
                    {
                        GetComponent<Image>().color = new Color(0, 1, 0, 0.35f);
                    }
                    else
                    {
                        GetComponent<Image>().color = new Color(1, 1, 1, 0.35f);
                    }
                }
                else
                {
                    GetComponent<Image>().color = Color.white;
                }
                break;
            case "Voleur":
                if (_adresse != -1)
                {
                    if (_adresse >= 12)
                    {
                        GetComponent<Image>().color = new Color(0, 1, 0, 0.35f);
                    }
                    else
                    {
                        GetComponent<Image>().color = new Color(1, 1, 1, 0.35f);
                    }
                }
                else
                {
                    GetComponent<Image>().color = Color.white;
                }
                break;
            case "Prêtre":
                if (_charisme != -1)
                {
                    if (_charisme >= 12)
                    {
                        GetComponent<Image>().color = new Color(0, 1, 0, 0.35f);
                    }
                    else
                    {
                        GetComponent<Image>().color = new Color(1, 1, 1, 0.35f);
                    }
                }
                else
                {
                    GetComponent<Image>().color = Color.white;
                }
                break;
            case "Mage":
                if (_intelligence != -1)
                {
                    if (_intelligence >= 12)
                    {
                        GetComponent<Image>().color = new Color(0, 1, 0, 0.35f);
                    }
                    else
                    {
                        GetComponent<Image>().color = new Color(1, 1, 1, 0.35f);
                    }
                }
                else
                {
                    GetComponent<Image>().color = Color.white;
                }
                break;
            case "Paladin":
                if (_courage != -1 && _intelligence != -1 && _charisme != -1 && _force != -1)
                {
                    if (_courage >= 12 && _intelligence >= 10 && _charisme >= 11 && _force >= 9)
                    {
                        GetComponent<Image>().color = new Color(0, 1, 0, 0.35f);
                    }
                    else
                    {
                        GetComponent<Image>().color = new Color(1, 1, 1, 0.35f);
                    }
                }
                else
                {
                    GetComponent<Image>().color = Color.white;
                }
                break;
            case "Ranger":
                if (_charisme != -1 && _adresse != -1)
                {
                    if (_charisme >= 10 && _adresse >= 10)
                    {
                        GetComponent<Image>().color = new Color(0, 1, 0, 0.35f);
                    }
                    else
                    {
                        GetComponent<Image>().color = new Color(1, 1, 1, 0.35f);
                    }
                }
                else
                {
                    GetComponent<Image>().color = Color.white;
                }
                break;
            case "Ménestrel":
                if (_charisme != -1 && _adresse != -1)
                {
                    if (_charisme >= 12 && _adresse >= 11)
                    {
                        GetComponent<Image>().color = new Color(0, 1, 0, 0.35f);
                    }
                    else
                    {
                        GetComponent<Image>().color = new Color(1, 1, 1, 0.35f);
                    }
                }
                else
                {
                    GetComponent<Image>().color = Color.white;
                }
                break;
            case "Marchand":
                if (_intelligence != -1 && _charisme != -1)
                {
                    if (_intelligence >= 12 && _charisme >= 11)
                    {
                        GetComponent<Image>().color = new Color(0, 1, 0, 0.35f);
                    }
                    else
                    {
                        GetComponent<Image>().color = new Color(1, 1, 1, 0.35f);
                    }
                }
                else
                {
                    GetComponent<Image>().color = Color.white;
                }
                break;
            case "Ingénieur":
                if (_adresse != -1)
                {
                    if (_adresse >= 11)
                    {
                        GetComponent<Image>().color = new Color(0, 1, 0, 0.35f);
                    }
                    else
                    {
                        GetComponent<Image>().color = new Color(1, 1, 1, 0.35f);
                    }
                }
                else
                {
                    GetComponent<Image>().color = Color.white;
                }
                break;
            case "Pirate":
                if (_courage != -1 && _adresse != -1)
                {
                    if (_courage >= 11 && _adresse >= 11)
                    {
                        GetComponent<Image>().color = new Color(0, 1, 0, 0.35f);
                    }
                    else
                    {
                        GetComponent<Image>().color = new Color(1, 1, 1, 0.35f);
                    }
                }
                else
                {
                    GetComponent<Image>().color = Color.white;
                }
                break;
            case "Noble":
                if (_intelligence != -1 && _charisme != -1)
                {
                    if (_intelligence >= 10 && _charisme >= 11)
                    {
                        GetComponent<Image>().color = new Color(0, 1, 0, 0.35f);
                    }
                    else
                    {
                        GetComponent<Image>().color = new Color(1, 1, 1, 0.35f);
                    }
                }
                else
                {
                    GetComponent<Image>().color = Color.white;
                }
                break;
        }
    }

    public void SelectIt()
    {
        Color c = new Color(0, 1, 0, 0.35f);
        if (GetComponent<Image>().color == c)
        {
            inputCourage.text = inputCourage.text + " ";
            inputIntelligence.text = inputIntelligence.text + " ";
            inputCharisme.text = inputCharisme.text + " ";
            inputAdresse.text = inputAdresse.text + " ";
            inputForce.text = inputForce.text + " ";
            GetComponent<Image>().color = Color.green;
        }
    }

}
