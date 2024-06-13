using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov_ball : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        sendBallInRandomDirection();
    }
    public void sendBallInRandomDirection()
    {
        rigidbody2D.velocity = Vector3.zero;
        rigidbody2D.isKinematic = true;
        transform.position = Vector3.zero;
        rigidbody2D.isKinematic = false;
        rigidbody2D.velocity = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized * 5f;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            sendBallInRandomDirection();
        }
    }
    ON`
}   
