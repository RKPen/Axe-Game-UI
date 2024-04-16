using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleSpawner : MonoBehaviour
{
    public GameObject applePrefab;

    float height, width;
    void Start()
    {
        Vector3 screenWorld = new Vector3(Screen.width, Screen.height, 0);
        screenWorld = Camera.main.ScreenToWorldPoint(screenWorld);
        height = screenWorld.y;
        width = screenWorld.x;

        int n = 4;
        float dx = width * 2 / n;
        float x = -width;
        
            StartCoroutine(SpawnApple(x, x + dx));
            x += dx;
        
        
        
        GameEvents.gameOverEvent.AddListener(Stop);
    }

    IEnumerator SpawnApple(float x1, float x2)
    {
        while (true)
        {
            GameObject appleInstance = GameObject.Instantiate(applePrefab);
            appleInstance.transform.position = new Vector3(Random.Range(x1, x2), height, 0);
            Destroy(appleInstance, 3f);
            yield return new WaitForSeconds(5f);
        }
    }
    public void Stop()
    {
        StopAllCoroutines();
    }
}
