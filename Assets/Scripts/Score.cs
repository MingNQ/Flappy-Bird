using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score instance { get; private set; }

    [SerializeField] private TextMeshProUGUI currentScoreText;
    [SerializeField] private TextMeshProUGUI bestScoreText;

    private int score;

    private void Awake()
    {
        if (instance == null)
            instance = this;

        currentScoreText.text = score.ToString();
        bestScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    private void UpdateHighScore()
    {
        if (score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);

            bestScoreText.text = score.ToString();
        }
    }

    public void UpdateScore()
    {
        score++;
        currentScoreText.text = score.ToString();
        UpdateHighScore();
    }

}
