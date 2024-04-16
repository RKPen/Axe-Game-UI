using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeSpawner : MonoBehaviour
{
    float deltaAngle = 4;
    public GameObject ground;
    public GameObject axePrefab;
    Coroutine SpawnAxeCoroutine;
    void Start()
    {
        GameEvents.gameOverEvent.AddListener(Stop);
        SpawnAxeCoroutine = StartCoroutine(SpawnAxe());
    }

    IEnumerator SpawnAxe()
    {
        while (true)
        {
            GameObject axeInstance = GameObject.Instantiate(axePrefab);
            Destroy(axeInstance, 3f);
            yield return new WaitForSeconds(2.5f);
        }
    }

    public void Stop()
    {
        StopCoroutine(SpawnAxeCoroutine);
    }
}
