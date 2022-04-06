using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
   [SerializeField] private Text Score;
   [SerializeField] private Text Coin;

   private Player _player;
   private void Start()
   {
      _player = FindObjectOfType<Player>();
   }

   private void Update()
   {
      Score.text = _player._score.ToString();
      Coin.text = _player._coin.ToString();
   }
}
