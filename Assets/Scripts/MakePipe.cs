using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    public float TimeDiff;
    float timer = 0;

    void Start()
    {
        timer = TimeDiff;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > TimeDiff)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = new Vector3(1.03f, Random.Range(-1.6f, 2.9f), 0);
            timer = 0;
        }
    }
}