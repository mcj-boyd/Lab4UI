using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeButtonText : MonoBehaviour {

    public Button button;

    public string valuePref = "VALUE_OPTION_BUTTON_TEXT";

	// Use this for initialization
	void Start () {
        Text buttonText = button.GetComponentInChildren<Text>();
        if (PlayerPrefs.HasKey(valuePref))
        {
            buttonText.text = PlayerPrefs.GetString(valuePref);
        }
        else
        {
            buttonText.text = "Ready...";
            PlayerPrefs.SetString(valuePref, buttonText.text);
            PlayerPrefs.Save();
        }
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ChangeText()
    {
        if(button)
        {
            // Gets the Text child object from the button so we can set its text.
            Text buttonText = button.GetComponentInChildren<Text>();
            if(buttonText.text == "Ready...")
            {
                buttonText.text = "Set...";
            }
            else if (buttonText.text == "Set...")
            {
                buttonText.text = "Go!";
            }
            else if (buttonText.text == "Go!")
            {
                buttonText.text = "Ready...";
            }

            PlayerPrefs.SetString(valuePref, buttonText.text);
            PlayerPrefs.Save();
        }
    }
}
