using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int _score = 0;

    public void AddScore(int addNum)
    {
        _score += addNum;
    }
}
