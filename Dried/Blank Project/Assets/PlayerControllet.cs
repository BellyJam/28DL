using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllet : MonoBehaviour
{
    public float speed = 5f;
    Vector3 Velocity;
    void Update()
    {
        Velocity = Vector3.zero;
        if (Input.GetKey("w"))
            Velocity.x = 1f;
        if (Input.GetKey("s"))
            Velocity.x = -1f;
        if (Input.GetKey("a"))
            Velocity.z = 1f;
        if (Input.GetKey("d"))
            Velocity.z = -1f;
        transform.Translate(Velocity.normalized * speed * Time.deltaTime);
    }
}
