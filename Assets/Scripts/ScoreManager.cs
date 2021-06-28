﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public Text ScoreDisp;

    void Update()
    {
        ScoreDisp.text = score.ToString();
    }

    void OnTriggerEnter2D(Collider2D other)
    { 
        if (other.CompareTag("obstacle"))
        {
            score++;
        }
    }
}
