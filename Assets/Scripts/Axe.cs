using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour
{

    private Rigidbody2D rb;
    
    float rotational_speed = 500;
    float speed = 10;
    void Start()
    {
        MovePlayer player = FindObjectOfType<MovePlayer>();
        
        Vector3 d = player.transform.position - transform.position;
        float t = Mathf.Abs(d.x) / speed;
        float g = Mathf.Abs(Physics2D.gravity.y);
        float vy = d.y/t + 0.5f * g * t;
        Vector2 v = new Vector2(-speed, vy);

        rb.velocity = v;
        Debug.DrawRay(transform.position, v);
    }

    void Update()
    {
        transform.Rotate(0, 0, rotational_speed * Time.deltaTime);
    }
}
