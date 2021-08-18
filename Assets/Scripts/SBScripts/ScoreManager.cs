using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    int totalLevelScore;

    public int currentScore;

    public Text scoreText, totalScore;
    public Sprite[] panelSprites;
    public Image winPanelSprite;


    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;
    }
     
    public void IncreaseScore()
    {
        currentScore++;
        scoreText.text = currentScore.ToString();
    }

    public void CalculateScore()
    {
        if (currentScore == totalLevelScore)
            winPanelSprite.sprite = panelSprites[2];

        if(currentScore >= (totalLevelScore * 0.5) && currentScore < totalLevelScore)
            winPanelSprite.sprite = panelSprites[1];

        if (currentScore < (totalLevelScore * 0.5))
            winPanelSprite.sprite = panelSprites[0];

        totalScore.text = currentScore + " / " + totalLevelScore;

    } 
}
