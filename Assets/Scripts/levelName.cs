using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class levelName : MonoBehaviour {

    public Text level;

	// Update is called once per frame
	void Update () {
        level.text = ("Level " + Engine.currentLevel);
	}
}
