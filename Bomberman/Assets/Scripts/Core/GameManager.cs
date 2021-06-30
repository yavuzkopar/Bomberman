using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoSingleton<GameManager>
{
    public int score;
    [SerializeField] Text scoreText;
    


    // Update is called once per frame
    void Update()
    {
        scoreText.text ="Gold " + score.ToString();
    }
   public void GameOver()
    {
        Debug.Log("Gaame Over");
    }
}
