using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;

    void Start()
    {
        for (int i = 0; i < 1; i++)
        {
            Instantiate(enemy);
        }
    }
}
