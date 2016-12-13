using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Menu : MonoBehaviour {

    public Canvas StartMenu;
    public Canvas CreateMenu;
    public Canvas Levels;
    public Button StartButton;
    public Button CreateButton;
    public Button back;
    public ParticleSystem Blast;
    public AudioSource click;
    public AudioSource bang;

    // Use this for initialization
    void Start()
    {
        StartMenu = StartMenu.GetComponent<Canvas>();
        CreateMenu = CreateMenu.GetComponent<Canvas>();
        Levels = Levels.GetComponent<Canvas>();
        StartButton = StartButton.GetComponent<Button>();
        CreateButton = CreateButton.GetComponent<Button>();
        back = back.GetComponent<Button>();

        CreateMenu.enabled = false;
        Levels.enabled = false;
        back.enabled = false;
    }

    public void CreatePress()
    {
        StartButton.enabled = false;
        CreateButton.enabled = false;
        StartMenu.enabled = false;
        CreateMenu.enabled = true;
        back.enabled = true;
    }

    public void StartPress()
    {
        StartCoroutine(Begin());
        StartCoroutine(BeginMenu());
        StartCoroutine(boom());
        StartCoroutine(pow());
        click.Play();
        Levels.enabled = true;
    }

    public void BackPress()
    {
        StartButton.enabled = true;
        CreateButton.enabled = true;
        StartMenu.enabled = true;
        CreateMenu.enabled = false;
        back.enabled = false;
    }

    IEnumerator Begin()
    {
        yield return new WaitForSeconds(0.3f);
        StartButton.enabled = false;
        CreateButton.enabled = false;
    }

    IEnumerator BeginMenu()
    {
        yield return new WaitForSeconds(0.3f);
        StartMenu.enabled = false;
    }

    IEnumerator boom()
    {
        yield return new WaitForSeconds(0.4f);
        Blast.Play();
    }

    IEnumerator pow()
    {
        yield return new WaitForSeconds(0.4f);
        bang.Play();
    }
}
