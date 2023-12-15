using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movent : MonoBehaviour
{
    [SerializeField]
    float speed;

    Rigidbody2D move;
    // Start is called before the first frame update
    void Start()
    {
        move = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            move.velocity = new Vector2(-speed, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            move.velocity = new Vector2(speed, 0);
        }
        else
            move.velocity = new Vector2(0, 0);
      
    }
  
}
