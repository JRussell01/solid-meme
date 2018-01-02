using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFoward : MonoBehaviour
{

    float maxSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        Vector3 Velocity = new Vector3(0, maxSpeed * Time.deltaTime, 0);

        pos += transform.rotation * Velocity;

        transform.position = pos;
    }
}
