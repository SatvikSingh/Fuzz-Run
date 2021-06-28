using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDispatEnd : MonoBehaviour
{
    public int score;
    public Text ScoreDisp;

    void Start()
    {
        score = ScoreManager.score;
        ScoreDisp.text = score.ToString();
    }
}
