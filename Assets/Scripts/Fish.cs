using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    [SerializeField] float jumpForce = 400f;
    Rigidbody2D RgBody;

    private void Start()
    {
        RgBody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RgBody.velocity = Vector3.zero;
            RgBody.AddForce(Vector3.up * jumpForce);
        }
    }
}
