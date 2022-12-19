using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    private float distance;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(obj1.transform.position, obj2.transform.position);
        print(distance);
    }
}
