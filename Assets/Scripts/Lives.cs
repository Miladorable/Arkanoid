using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public int lives = 3;
    public TMPro.TextMeshProUGUI LifeText;
    public GameObject Lifecanva;


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
            Lifecanva.SetActive(true);
            Time.timeScale = 0;
        }  

    }
    
}