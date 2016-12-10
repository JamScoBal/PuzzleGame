using UnityEngine;
using System.Collections;
using UnityEngine.UI;

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
            switch(PlayerPrefs.HasKey(i.ToString()))
            {
                case true:
                progint++;
                    break;
                default:
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
            switch(getScore(currentLevel.ToString()) > numberOfMoves)
            {
                case true:
                PlayerPrefs.SetInt(currentLevel.ToString(), numberOfMoves);
                    break;
                default:
                PlayerPrefs.SetInt(currentLevel.ToString(), numberOfMoves);
                    break;
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
