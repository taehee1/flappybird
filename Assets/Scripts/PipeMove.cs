 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float PipeSpeed;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Vector3.left * PipeSpeed * Time.deltaTime;
    }
}
