﻿using UnityEngine;
using System.Collections;

public class HT_Explode : MonoBehaviour
{

    public GameObject explosion;
    public ParticleSystem[] effects;
    GameObject player;
    GameObject bomb;

    private void Start()
    {
        bomb = gameObject;
        player = GameObject.Find("Ship");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Instantiate(explosion, transform.position, transform.rotation);
            foreach (var effect in effects)
            {
                effect.transform.parent = null;
                effect.Stop();
                Destroy(effect.gameObject, 1.0f);
            }
            Destroy(bomb);
            Destroy(player);
        }
    }
}
