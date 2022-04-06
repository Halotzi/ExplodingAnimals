using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int _score = 0;
    public int _coin = 0;

    public void AddScore(int addNum)
    {
        _score += addNum;
    }
    
    public void AddCoin(int addNum)
    {
        _coin += addNum;
    }
}
