using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GameData 
{
    private int highScore;
    private float oyuncu;
    public GameData(int highScore, float oyuncu)
    {
        this.highScore = highScore;
        this.oyuncu = oyuncu;
    }
    public int getHighScore()
    {
        return highScore;
    }
    public float getOyuncuY()
    {
        return oyuncu;
    }

}

