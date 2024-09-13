using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
   public int PlayerScore;
   public Text scoreTexe;

   public GameObject GameOver;

   [ContextMenu("Increase Score")]
   public void addScore(int scoreToAdd)
   {
    PlayerScore=PlayerScore+scoreToAdd;
    scoreTexe.text=PlayerScore.ToString();
   }
   public void restartGame()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);

   }
   public void gameOver()
   {
    GameOver.SetActive(true);
   }
}
