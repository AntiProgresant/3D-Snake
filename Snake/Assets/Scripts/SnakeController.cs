﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeController : MonoBehaviour
{
    public float speed = 10f;
    public float boost = 5;

    float roll;
    float pitch;
    float yaw;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        yaw = Input.GetAxis("Horizontal");
        pitch = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up * yaw * 300f * Time.deltaTime, Space.Self);
        transform.Rotate(Vector3.right * pitch * 300f * Time.deltaTime, Space.Self);

        if (Input.GetKeyDown("Space"))
        {
            speed = speed + boost;
        }
        else
        {
            speed = speed;
        }

    }
}
