using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score = 0;
    public TMPro.TextMeshProUGUI ScoreText;
    public TMPro.TextMeshProUGUI ScoreTextFinal;
    public GameObject canvas;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Brick"))
        {
            score += 1;
            ScoreText.text = "Score : " + score;
            ScoreTextFinal.text = ScoreText.text;
        }

    }

    private void Update()
    {
        if(score==25)
        {
            canvas.SetActive(true);
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(0);
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
