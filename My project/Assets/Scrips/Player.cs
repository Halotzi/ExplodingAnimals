using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;
    public int _score = 0;
    public int _coin = 0;
    public int danage = 1;

    public void Awake()
    {
        instance = this;
    }

    public void AddScore(int addNum)
    {
        _score += addNum;
    }
    
    public void AddCoin(int addNum)
    {
        _coin += addNum;
    }
}
