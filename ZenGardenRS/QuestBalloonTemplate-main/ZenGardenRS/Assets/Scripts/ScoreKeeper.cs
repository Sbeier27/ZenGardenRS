using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreKeeper : MonoBehaviour
{
    public int score = 0;
    public Text Score;
    public int ZenScore;
    public Text Zenscore;

    public void IncrementScore()
    {
        score += 1;
        
        if (ZenScore == 1) //
        {
            LoadScene("EndScreen");
        }
        if (score > 0 && score % 9 == 0) {
            ZenScore += 1;
        }
        UpdateScoreDisplay();
    }

    public void IncrementZenScore()
    {
        ZenScore += 1;
        UpdateScoreDisplay();
        if (ZenScore == 3)
        {
            LoadScene("EndScreen");
        }
    }

    public void UpdateScoreDisplay()
    {
        Score.text = "Score: " + score;
        Zenscore.text = "Zen Score: " + ZenScore;
    }

    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    void Start()
    {
        UpdateScoreDisplay();
    }
}
