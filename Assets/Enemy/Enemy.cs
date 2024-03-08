using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float time;
    private float attackTimer;
    private float interval = 2;
    private float attackInterval = 2;
    public float speed;
    public GameObject attack;
    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * speed;
        time += Time.deltaTime;
        attackTimer += Time.deltaTime;

        if(time > interval)
        {
            speed = -speed;
            time = 0f;
            interval = Random.Range(3.0f, 10.0f);
        }

        if(attackTimer > attackInterval)
        {
            Instantiate(attack, transform.position + Vector3.back * 4, Quaternion.identity);
            attackTimer = 0f;
            attackInterval = Random.Range(3.0f, 8.0f);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        if(collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Enemy")
        {
            speed = -speed;
            time = 0f;
            interval = Random.Range(3.0f, 10.0f);
        }
    }
}
