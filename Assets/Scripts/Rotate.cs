using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotateSpeed;

    private float moveX;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        moveX = Input.GetAxis("Mouse X") + Input.GetAxis("Horizontal");

        if(Input.GetMouseButton(0) || Input.GetKeyDown(KeyCode.Space))
        {
            transform.Rotate(0f, moveX * rotateSpeed * Time.deltaTime, 0f);
        }
    }
}
 