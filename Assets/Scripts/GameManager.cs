using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    // Singleton instance for the manager
    public static GameManager instance;

    public TextMeshProUGUI scoreUI;

    public int asteroidPoints = 10;
    protected int score;

    /*
     * Source: https://discussions.unity.com/t/question-about-creating-game-manager-using-singleton-design-concept/826050
     */
    public static GameManager GetInstance()
    {
        if (instance is null)
        {
            GameObject go = new GameObject("GameManager");
            go.AddComponent<GameManager>();
        }

        return instance;
    }

    public void Awake()
    {
        instance = this;
    }

    public void Update()
    {
        scoreUI.SetText("Score: " + score);
    }

    public void ScoreAsteroid()
    {
        score += asteroidPoints;
    }
}
