using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] float speed = 2.5f;
    [SerializeField] float randomOffset = 2f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * speed * Vector3.left;

        if (transform.position.x <= -15)
        {
            float randomHight = UnityEngine.Random.Range(-randomOffset, randomOffset);
            transform.position = new Vector3(15, randomHight, transform.position.z);
        }
    }
}
