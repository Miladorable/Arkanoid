using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public int Score = 0;
    public TMPro.TextMeshProUGUI ScoreText;
    public TMPro.TextMeshProUGUI ScoreTextFinalWin;
    public TMPro.TextMeshProUGUI ScoreTextFinalLoose;
    public GameObject Wincanva;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Brick"))
        {
            Score += 1;
            ScoreText.text = "Score : " + Score;
            ScoreTextFinalWin.text = ScoreText.text;
            ScoreTextFinalLoose.text = ScoreText.text;
        }

    }

    private void Update()
    {
        if(Score==25)
        {
            Wincanva.SetActive(true);
            Time.timeScale = 0;
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
