using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleFall : MonoBehaviour
{
    float speed = 8;
    private int weight;

    public int Weight
    {
        get { return weight; }
        set { weight = Mathf.Clamp(value, 1, 10); }
    }
    // Start is called before the first frame update
    void Start()
    {
        weight = Random.Range(1, 11);
        transform.localScale *= weight/3f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector3.up * speed * Time.deltaTime);
    }
}
