using UnityEngine;
using System.Collections;
using System;

public class Actions : MonoBehaviour {


    // Use this for initialization
    void Start () {
        Action sayYay = () => { Debug.Log("Yay!"); };
        sayYay();

        Action sayYippy = () => { Debug.Log("Yippy!"); };
        sayYippy();

        Action sayWoohoo = () => { Debug.Log("Woohoo!"); };
        sayWoohoo();

        Action sayYouCanDoIt = () => { Debug.Log("You can do it!"); };
        sayYouCanDoIt();
    }
	
}
