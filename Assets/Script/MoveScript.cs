using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlanetspeeed : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float deadZone;
    // Start is called before the first frame update
    void Start()
    {
        deadZone = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 3f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
