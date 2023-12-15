using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class bollmovment : MonoBehaviour
{
    [SerializeField]
    float speed;
   
    [SerializeField]
    GameObject boll;
    
    
  
   
    Rigidbody2D move;
    // Start is called before the first frame update
    void Start()
    {
        move = GetComponent<Rigidbody2D>();
        move.AddForce(new Vector2(speed, speed));
    }

    // Update is called once per frame
    void Update()
    {
   
        move.velocity = move.velocity.normalized * speed;
        if (transform.position.y < -10) 
        {
            textpoäng.poäng++;
            transform.position = new Vector2(-6,-2);
            speed = 10;
        }

    }

   
    void OnCollisionEnter2D(Collision2D collision)
    {


        if (math.abs(move.velocity.y) < 2)
            move.AddForce(new Vector2(0, -1));

        var othergameobject = collision.gameObject;
        square hitblock = othergameobject.GetComponent<square>();

        if (hitblock != null)
        {
           var hp= hitblock.TakeDamage();

            speed = speed  -hp+2;
            if (speed <= 9)
            {
                speed = 10;
            }
           if (speed > 20)
           {
              textantal.antal++;
               var nyboll = Instantiate(this, transform.position + new Vector3(0, 0, 0), Quaternion.identity);
               nyboll.speed = 15;
                speed = 15;
           }
                
            
           // Destroy(othergameobject);
        }
    }
}
