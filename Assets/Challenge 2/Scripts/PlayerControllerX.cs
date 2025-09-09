using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timer = 1.5f;
    private readonly float dogSpawnInterval = 1.0f;

    // Update is called once per frame
    void Update()
    {
        CountTime();

        // On spacebar press, send dog
        if (timer >= dogSpawnInterval && Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timer = 0;
        }
    }

    void CountTime()
    {
        if (timer < dogSpawnInterval)
        {
            timer += Time.deltaTime;
        }
    }
}
