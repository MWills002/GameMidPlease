using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaNaFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, 0.02f);
    }
}
