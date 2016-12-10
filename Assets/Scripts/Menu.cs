using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

    public Canvas StartMenu;
    public Button StartButton;

    // Use this for initialization
    void Start()
    {
        StartMenu = StartMenu.GetComponent<Canvas>();
        StartButton = StartButton.GetComponent<Button>();
    }

    public void StartPress()
    {
        StartButton.enabled = false;
        StartMenu.enabled = false;
    }
}
