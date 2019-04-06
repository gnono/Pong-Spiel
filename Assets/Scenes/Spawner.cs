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
                Instantiate(prefab, new Vector3(1.5F * x, 1.5F * y, 0), Quaternion.Euler(0,0,30));
            }
        }
    }

}


//Vector3[] pos;
//public GameObject[] obj;

//void Start()
//{
//    for (int i = 0; i < obj.Length; i++)
//    {
//        pos = new Vector3[obj.Length];
//        pos[0] = new Vector3(transform.position.x-6 + i, transform.position.y +1.2F, transform.position.z+6);
//        pos[1] = new Vector3(transform.position.x-6 + i, transform.position.y +1.2F, transform.position.z+6);
//        pos[2] = new Vector3(transform.position.x - 6 + i, transform.position.y + 1.2F, transform.position.z + 6);
//        //etc...
//        Instantiate(obj[i], pos[0], transform.rotation);
//        Instantiate(obj[i], pos[1], transform.rotation);
//        Instantiate(obj[i], pos[2], transform.rotation);
//        //etc...
//    }
//}
