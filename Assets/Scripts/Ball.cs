using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D Rb2d;
    [SerializeField]
    private float launchForce = 200f;
    public float BonusDropChance = 0.3f;
    public GameObject BonusAllongement;
    public GameObject BonusVitesse;

    public void Start()
    {
        // Pour que la balle puisse se déplacer  dans le Lvl sans être soumise à la gravité
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
            
            float _chanceOfDrop = Random.value;
            float _whichBonus = Random.value;
            if (_chanceOfDrop <= BonusDropChance) // Faire en sorte qu'il y ai 30% de chance de drop un objet a la destruction d'une brique
            {
                if (_whichBonus < 0.5f) // Et que l'un des deux bonus qui tombe soit, soit un allongement, soit une augmentation de la vitesse de la balle
                {
                    Instantiate(BonusAllongement, collision.gameObject.transform.position, Quaternion.identity);
                }

                else
                {
                    Instantiate(BonusVitesse, collision.gameObject.transform.position, Quaternion.identity);
                }
            }
            Destroy(collision.gameObject);
        }


        if (collision.gameObject.CompareTag("ground"))
        {
            Rb2d.transform.position = new Vector3(-0.3f, -7f, 0f);
        }

    }
}