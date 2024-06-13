using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rigidbody2D;
    public KeyCode upKey;
    public KeyCode DownKey;
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        print("hello from start");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(upKey))
        {
            rigidbody2D.velocity = Vector2.up;

        }
        if (Input.GetKey(DownKey))
        {
            rigidbody2D.velocity = Vector2.down;

        }
        else 
        {
            rigidbody2D.velocity = Vector2.zero;

        }
    }


    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
    }

}

