using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private GameObject _cloudEffect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        BirdRender birdRender = collision.collider.GetComponent<BirdRender>();
        if (birdRender != null)
        {
            Instantiate(_cloudEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            return;
        }

        Enemy enemy = collision.collider.GetComponent<Enemy>();
        if (enemy != null)
        {
            return;
        }

        if (collision.contacts[0].normal.y < -0.5)
        {
            Instantiate(_cloudEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
