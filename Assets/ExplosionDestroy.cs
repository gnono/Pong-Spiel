using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionDestroy : MonoBehaviour
{
    public GameObject Object;
    public GameObject effect;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Target")
        {
            Instantiate(effect, Object.transform.position, Object.transform.rotation);
            Destroy(Object, 0.2f);
            Debug.Log("Collision registered and Object destroyed");
        }
    }

}
