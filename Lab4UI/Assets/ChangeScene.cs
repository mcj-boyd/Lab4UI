using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class ChangeScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ChangeSceneWithName(string sceneName)
    {
        // Load the Scene specified by the button click.
        SceneManager.LoadScene(sceneName);
    }
}
