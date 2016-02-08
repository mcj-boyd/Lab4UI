using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeTextWithSlider : MonoBehaviour {

    public Slider valueSlider;
    public Text text;
    public string valuePref = "VALUE_SLIDER_INITIAL_VALUE";

    // Use this for initialization
    void Start () {
        if (PlayerPrefs.HasKey(valuePref))
        {
            valueSlider.value = PlayerPrefs.GetFloat(valuePref);
            text.text = "" + valueSlider.value;
        }
        else
        {
            PlayerPrefs.SetFloat(valuePref, valueSlider.value);
            PlayerPrefs.Save();
            text.text = "" + valueSlider.value;
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ChangeSlider()
    {
        if (valueSlider && text)
        {
            float value = valueSlider.value;
            text.text = "" + value;
            PlayerPrefs.SetFloat(valuePref, valueSlider.value);
            PlayerPrefs.Save();
        }
    }
}
