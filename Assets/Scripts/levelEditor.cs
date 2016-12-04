using UnityEngine;
using System.Collections;
using System.IO;

public class levelEditor : MonoBehaviour {

    public string levNumber;
    string runtimeLevels;
    private int clear = 1;

    public void setLevelName(string nr)
    {
        levNumber = nr;
    }

    public void ClearButton()
    {
        while(clear<26)
        {
            clear++;
            if(GameObject.Find(clear.ToString()).GetComponent<lightSwitch>().isOn)
            {
                GameObject.Find(clear.ToString()).GetComponent<lightSwitch>().change();
            }
        }
    }

    public void SaveButton()
    {
        string levelstring = "";

        while(clear<26)
        {
            clear++;
            if(GameObject.Find(clear.ToString()).GetComponent<lightSwitch>().isOn)
            {
                if (levelstring.Length == 0) levelstring = clear.ToString();
                else levelstring += "," + clear;
            }
        }
        runtimeLevels +=
            "\n\n" +
            "<level>" + "\n" +
            "<levelname>" + levNumber + "</levelname>" + "\n" +
            "<setup>" + levelstring + "</setup>" + "\n" +
            "</level>"
            ;
        System.IO.File.WriteAllText("/Users/james/Documents/GitKraken/PuzzleGame/Assets/Resources/editor.txt", runtimeLevels);
    }
}
