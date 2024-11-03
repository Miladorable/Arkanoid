using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public float Lives = 3f;
    public Text LifeText;
    public float Dammages = 1f;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
        {
            Lives -= -1f;
            //LifeText.text = "Lives : " - Dammages;
        }

        if (Lives <= 0)
        {
            Lives = 0;
            SceneManager.LoadSceneAsync(1);
        }

    }

}