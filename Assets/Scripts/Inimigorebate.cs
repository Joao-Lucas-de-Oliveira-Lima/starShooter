using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigorebate : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 direction;
    public float velocidade = 5f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = new Vector2(1f, 1f).normalized; // Movimento diagonal inicial
    }

    private void Update()
    {
        rb.velocity = direction * velocidade;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("parede"))
        {
            // Rebate a dire��o ao colidir com uma parede
            direction = Vector2.Reflect(direction, collision.contacts[0].normal);
        }
    }
}