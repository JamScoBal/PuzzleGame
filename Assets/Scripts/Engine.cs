using UnityEngine;
using System.Collections;

public class Engine : MonoBehaviour {

    int numberOfLevels;
    public int currentLevel;
    public int numberOfMoves;

    public void init(int nr)
    {
        numberOfMoves = nr;
        currentLevel = getProgress();
    }

    int getProgress()
    {
        int progint = 0;
        for(int i=0; i < numberOfLevels+1; i++)
        {
            if(PlayerPrefs.HasKey(i.ToString()))
            {
                progint++;
            }
            else
            {
                progint++;
                break;
            }
        }
        return progint;
    }

    int getScore(string lev)
    {
        return PlayerPrefs.GetInt(lev);
    }

    void saveScore()
    {
        if(PlayerPrefs.HasKey(currentLevel.ToString()))
        {
            if(getScore(currentLevel.ToString()) > numberOfMoves)
            {
                PlayerPrefs.SetInt(currentLevel.ToString(), numberOfMoves);
            }
            else
            {
                PlayerPrefs.SetInt(currentLevel.ToString(), numberOfMoves);
            }
        }
    }

    public void startGame()
    {
        this.gameObject.GetComponent<levelHandler>().loadLevel(currentLevel);
    }

    public void gameFinished()
    {
        saveScore();
        currentLevel++;
        numberOfMoves = 0;
        this.gameObject.GetComponent<levelHandler>().loadLevel(currentLevel);
    }
}
