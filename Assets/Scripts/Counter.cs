using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
  public Text CounterText;

  private int Count = 0;

  private void Start()
  {
    Count = 0;
  }

  private void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("GreenProjectile") == CompareTag("GreenBox"))
    {
      UpdateScore(3);
    }
    else if (other.CompareTag("GreenProjectile") != CompareTag("GreenBox"))
    {
      UpdateScore(1);
    }
  }

  private void UpdateScore(int increaseByAmmount)
  {
    Count += increaseByAmmount;
    CounterText.text = "Count : " + Count;
  }
}
