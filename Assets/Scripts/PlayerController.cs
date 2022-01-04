using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;
    Rigidbody2D rb2D;
    float xRange = 8.5f;
    // Start is called before the first frame update
    void Awake()
    {
       rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horiziontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 position = transform.position;

        position.x += 5.0f * horiziontal * Time.deltaTime;
        position.y += 5.0f * vertical * Time.deltaTime;

        transform.position = position;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Launch();
        }
        if(transform.position.x > xRange )
        {
            transform.position = new Vector2(xRange, transform.position.y);
        }
        else if (transform.position.x < -xRange )
        {
            transform.position = new Vector2(-xRange, transform.position.y);
        }
    }
    void Launch()
    {
        GameObject projectileObject = Instantiate(projectilePrefab, rb2D.position + Vector2.up * 0.5f, Quaternion.identity);

        Projectile projectile = projectileObject.GetComponent<Projectile>();

        projectile.Shoot(new Vector2(0, 1), 500);

    }
}
