using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject Object;
    public GameObject ObjectToDestroy; // drag your explosion prefab here

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject == Object)
        {
            ObjectToDestroy.SetActive(false);
            Debug.Log("Collision registered and Object destroyed");
        }
    }
}
