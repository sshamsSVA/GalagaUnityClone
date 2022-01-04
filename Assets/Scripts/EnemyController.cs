using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 0;
    public float timer = 3;
    public int direction = 1;
    float changeTime;
    float xRange = 9.0f;
    // Start is called before the first frame update
    void Start()
    {
        changeTime = timer;
    }
    // Update is called once per frame
    void Update()
    {
        changeTime -= Time.deltaTime;
        Vector2 position = transform.position;
        if (changeTime < 0 || transform.position.x > xRange || transform.position.x < -xRange) {
            direction = -direction;
            changeTime = timer;
        }
        position.x = position.x + Time.deltaTime * speed * direction;
        transform.position = position;

       
    }
}
