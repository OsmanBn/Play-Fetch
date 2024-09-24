using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public bool spaceBar = true;
    private float spaceBarInterval = 2.0f;

    void Start()
    {
        InvokeRepeating("EnableSpaceBar", 0.0f, spaceBarInterval);
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (spaceBar)
            {
                spaceBar = false;
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            }

        }

    }

    void EnableSpaceBar()
    {
        spaceBar = true;
    }

}
