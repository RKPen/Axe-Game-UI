using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        AppleFall a = collision.gameObject.GetComponent<AppleFall>();
        if(a != null)
        {
            GameEvents.UpdateHealth.Invoke(a.Weight);
            Destroy(collision.gameObject);
        }
        else{
            GameEvents.UpdateHealth.Invoke(-20);
            StartCoroutine(flicker());
        }
       
    }
    IEnumerator flicker()
    {
        WaitForSeconds pause = new WaitForSeconds(0.125f);
        for (int i = 0; i < 4; i++)
        {
            GetComponent<SpriteRenderer>().enabled = false;
            yield return pause; 
            GetComponent<SpriteRenderer>().enabled = true;
            yield return pause;
        }
    }
}
