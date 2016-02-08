using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ToggleButtonScript : MonoBehaviour {

    public Toggle toggle;
    public Button toggledButton;

    public string valuePref = "VALUE_OPTION_BUTTON_INTERACTABLE";

    // Use this for initialization
    void Start()
    {
        
        if (PlayerPrefs.HasKey(valuePref))
        {
            if (PlayerPrefs.GetInt(valuePref) == 1)
            {
                toggledButton.interactable = true;
                
            }
            else
            {
                toggledButton.interactable = false;
                toggle.isOn = false;
            }
        }
        else
        {
            toggledButton.interactable = true;
            PlayerPrefs.SetInt(valuePref, 1);
            PlayerPrefs.Save();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ToggleOptionButton()
    {
        if (toggle)
        {
            if (toggle.isOn)
            {
                toggledButton.interactable = true;
                PlayerPrefs.SetInt(valuePref, 1);

            }
            else
            {
                toggledButton.interactable = false;
                PlayerPrefs.SetInt(valuePref, 0);
            }

            PlayerPrefs.Save();
        }
    }

}
