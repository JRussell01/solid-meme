using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public float fireDelay = 0.25f;
    float cooldownTimer = 0;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        cooldownTimer -= Time.deltaTime;

        if (Input.GetButton("Fire1") && cooldownTimer <= -0.25)
        {
            //SHOOT!
            Debug.Log("Pew!");
            cooldownTimer = fireDelay;

            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }

    }

}


