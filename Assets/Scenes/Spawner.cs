using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform prefab;

    void Start()
    {
        for (int y = 0; y < 7; y++)
        {
            for (int x = 0; x < 7; x++)
            {
                Instantiate(prefab, new Vector3(1.5F * x, 1.5F * y, 0), Quaternion.Euler(0,0,0));
            }
        }
    }

}

