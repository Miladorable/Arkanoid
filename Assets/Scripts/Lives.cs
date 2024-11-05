using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class lives : MonoBehaviour
{
    public int Lives = 3;
    public TMPro.TextMeshProUGUI LifeText;
    public GameObject Loosecanva;


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Ball"))
        {
            Lives -- ;
            LifeText.text = "Lives : " + Lives;
        }

        if (Lives <= 0)
        {
            Lives = 0;
            Loosecanva.SetActive(true);
            Time.timeScale = 0;
        }  

    }
    
}