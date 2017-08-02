using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateOrigine : MonoBehaviour {

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

    private string _origine;

    public void Maj ()
    {
        if(inputCourage.text != null && inputCourage.text != "")
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

        _origine = transform.GetChild(0).GetComponent<Text>().text;
        switch (_origine)
        {
            case "Humain":
                if (_courage != -1 || _intelligence != -1 || _charisme != -1 || _adresse != -1 || _force != -1)
                {
                    GetComponent<Image>().color = new Color(0, 1, 0, 0.35f);
                }
                else
                {
                    GetComponent<Image>().color = Color.white;
                }
                break;
            case "Barbare":
                if (_courage != -1 && _force != -1)
                {
                    if (_courage >= 12 && _force >= 13)
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
            case "Nain":
                if (_courage != -1 && _force != -1)
                {
                    if (_courage >= 11 && _force >= 12)
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
            case "Haut Elfe":
                if (_intelligence != -1 && _charisme != -1 && _adresse != -1 && _force != -1)
                {
                    if (_intelligence >= 11 && _charisme >= 12 && _adresse >= 12 && _force <= 12)
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
            case "Demi-Elfe":
                if (_charisme != -1 && _adresse != -1)
                {
                    if (_charisme >= 10 && _adresse >= 11)
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
            case "Elfe Sylvain":
                if (_charisme != -1 && _adresse != -1 && _force != -1)
                {
                    if (_charisme >= 12 && _adresse >= 10 && _force <= 11)
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
            case "Elfe Noir":
                if (_intelligence != -1 && _adresse != -1)
                {
                    if (_intelligence >= 12 && _adresse >= 13)
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
            case "Orque":
                if (_intelligence != -1 && _charisme != -1 && _force != -1)
                {
                    if (_intelligence <= 8 && _charisme <= 10 && _force >= 12)
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
            case "Demi-Orque":
                if (_intelligence != -1 && _adresse != -1 && _force != -1)
                {
                    if (_intelligence <= 10 && _adresse <= 11 && _force >= 12)
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
            case "Gobelin":
                if (_courage != -1 && _intelligence != -1 && _charisme != -1 && _force != -1)
                {
                    if (_courage <= 10 && _intelligence <= 10 && _charisme <= 8 && _force <= 9)
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
            case "Ogre":
                if (_intelligence != -1 && _charisme != -1 && _adresse != -1 && _force != -1)
                {
                    if (_intelligence <= 9 && _charisme <= 10 && _adresse <= 11 && _force >= 13)
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
            case "Hobbit":
                if (_courage != -1 && _intelligence != -1 && _force != -1)
                {
                    if (_courage >= 12 && _intelligence >= 10 && _force <= 10)
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
            case "Gnôme":
                if (_intelligence != -1 && _adresse != -1 && _force != -1)
                {
                    if (_intelligence >= 10 && _adresse >= 13 && _force <= 8)
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

}
