using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    public Rigidbody2D Rb2d;
    [SerializeField]
    private float launchForce = 200f;
    public float BonusDropChance = 0.5f;

    public void Start()
    {
        Rb2d = gameObject.GetComponent<Rigidbody2D>();
        Vector2 _launch = Vector2.zero;
        _launch.x = Random.Range(-0.5f, 0.5f);
        _launch.y = 1;
        Rb2d.AddForce(_launch * launchForce);
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Brick"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("ground"))
        {
            Rb2d.transform.position = new Vector3(-0.3f, -7f, 0f);
        }

    }
}