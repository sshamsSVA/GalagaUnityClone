using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    
    Rigidbody2D rb2D;
    float speed = 30;
    float yLimit = 0.27f;
    // Start is called before the first frame update
    void Awake()
    {
       rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > yLimit)
        {
            Destroy(gameObject);
        }
    }

    public void Shoot(Vector2 direction, float force)
    {
       rb2D.AddForce(direction * force);
    }
    void OnCollisionEnter2D(Collision2D other) 
    {
        Destroy(gameObject);    
        Destroy(other.gameObject);
    }
}
