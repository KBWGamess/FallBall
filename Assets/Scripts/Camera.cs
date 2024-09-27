using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform ball;
    public float smoothSpeed;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - ball.position;
    }


    void Update()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, offset + ball.position, smoothSpeed);
        transform.position = newPos;
    }
}
