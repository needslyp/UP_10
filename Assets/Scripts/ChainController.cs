using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainController : MonoBehaviour
{
    public float speed = 1f;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 7, 0), speed * Time.deltaTime);
    }
}
