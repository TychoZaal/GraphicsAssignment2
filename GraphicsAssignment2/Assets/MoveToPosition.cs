using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPosition : MonoBehaviour
{
    public Transform[] target;
    public float speed;
    public Transform targetObject;

    private int current;

    // Update is called once per frame
    void Update()
    {
        if (transform.position != target[current].position)
        {
            targetObject = target[current];
            Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        else current = (current + 1) % target.Length;
    }
}
