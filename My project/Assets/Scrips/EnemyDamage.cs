using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] private int _health = 10;
    private void OnMouseDown()
    {
        _health--;

        if (_health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
