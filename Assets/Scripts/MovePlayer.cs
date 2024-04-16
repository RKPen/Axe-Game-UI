using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    float width;
    public float speed = 1f;
    void Start()
    {
        width = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x;
        width -= GetComponent<SpriteRenderer>().sprite.bounds.extents.x;
        GameEvents.gameOverEvent.AddListener(Die);
    }
    void Die()
    {
        Destroy(this.gameObject);
    }
    void Update()
    {
        Vector2 pos = transform.position;
        float dx = Input.GetAxis("Horizontal");
        if (dx != 0){
            pos.x += dx * speed * Time.deltaTime;
        }
        else
        {
            Vector2 mouse = Input.mousePosition;
            mouse = Camera.main.ScreenToWorldPoint(mouse);
            pos.x = mouse.x;
        }
        pos.x = Mathf.Clamp(pos.x, -width, width);
        transform.position = pos;
    }
 


}
