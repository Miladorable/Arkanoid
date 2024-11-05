using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public int lives = 3;
    public TMPro.TextMeshProUGUI LifeText;


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Ball"))
        {
            lives -- ;
            LifeText.text = "lives : " + lives;
        }

        if (lives <= 0)
        {
            lives = 0;
            SceneManager.LoadSceneAsync(1);
        }

    }
    
}