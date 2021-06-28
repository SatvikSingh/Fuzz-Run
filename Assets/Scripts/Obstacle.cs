using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obstacle : MonoBehaviour
{
    public int Damage = 1;
    public float speed;
    public GameObject HitEffect;
    public GameObject HitSound;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Instantiate(HitEffect, transform.position, Quaternion.identity);
            Instantiate(HitSound, transform.position, Quaternion.identity);
            other.GetComponent<PlayerMovement>().PlayerHP -= Damage;
            Destroy(gameObject);
        }
    }

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
