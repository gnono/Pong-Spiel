using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncy_Ball : MonoBehaviour
{
    Rigidbody _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        // Increase max angular velocity or we won't see much spin.
        _rb.maxAngularVelocity = 1000;
        StartCoroutine(ChangeRotation());
    }
    private IEnumerator ChangeRotation()
    {
        while (true)
        {
            _rb.AddTorque(new Vector3(10 * UnityEngine.Random.Range(0, 3f), UnityEngine.Random.Range(0, 3f), UnityEngine.Random.Range(0, 3f)), ForceMode.VelocityChange);
            yield return new WaitForSeconds(1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
