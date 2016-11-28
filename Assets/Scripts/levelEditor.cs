using UnityEngine;
using System.Collections;
using System.IO;

public class levelEditor : MonoBehaviour {

    public string levNumber;
    string runtimeLevels;

    public void setLevelName(string nr)
    {
        levNumber = nr;
    }

    public void ClearButton()
    {
        for(int i = 1; i<26; i++)
        {
            if(GameObject.Find(i.ToString()).GetComponent<lightSwitch>().isOn)
            {
                GameObject.Find(i.ToString()).GetComponent<lightSwitch>().change();
            }
        }
    }

    public void SaveButton()
    {
        string levelstring = "";

        for(int i = 1; i<26; i++)
        {
            if(GameObject.Find(i.ToString()).GetComponent<lightSwitch>().isOn)
            {
                if (levelstring.Length == 0) levelstring = i.ToString();
                else levelstring += "," + i;
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
