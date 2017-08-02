using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplaySelectedButton : MonoBehaviour {

    public Button[] buttons;
    public Text display;

    public void Display()
    {
        display.text = "";
        display.transform.GetChild(0).gameObject.SetActive(false);

        foreach (Button btn in buttons)
        {
            if(btn.GetComponent<Image>().color == Color.green)
            {
                btn.GetComponent<UpdateOrigine>().Maj();
            }
        }

        Color c = new Color(0, 1, 0, 0.35f);
        if (GetComponent<Image>().color == c)
        {
            GetComponent<Image>().color = Color.green;
            display.text = transform.GetChild(0).GetComponent<Text>().text;
            display.transform.GetChild(0).gameObject.SetActive(true);
        }
        else
        {
            return;
        }
    }

    public void DisplayMetier()
    {
        display.text = "";
        display.transform.GetChild(0).gameObject.SetActive(false);

        foreach (Button btn in buttons)
        {
            if (btn.GetComponent<Image>().color == Color.green)
            {
                btn.GetComponent<UpdateMetier>().Maj();
            }
        }

        Color c = new Color(0, 1, 0, 0.35f);
        if (GetComponent<Image>().color == c)
        {
            GetComponent<Image>().color = Color.green;
            display.text = transform.GetChild(0).GetComponent<Text>().text;
            display.transform.GetChild(0).gameObject.SetActive(true);
        }
        else
        {
            return;
        }
    }

}
