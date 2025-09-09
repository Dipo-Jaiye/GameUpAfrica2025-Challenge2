using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timer = 1.0f;
    private readonly float dogSpawnInterval = 1.0f;

    // Update is called once per frame
    void Update()
    {
        // this keeps track of how much time has elapsed
        CountTime();

        // On spacebar press, send dog
        if (timer >= dogSpawnInterval && Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            // reset the timer after instantiation
            timer = 0;
        }
    }

    void CountTime()
    {
        // this check ensures the timer does not keep counting up infinitely
        if (timer < dogSpawnInterval)
        {
            timer += Time.deltaTime;
        }
    }
}
