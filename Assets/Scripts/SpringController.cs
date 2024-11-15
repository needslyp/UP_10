using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpringController : MonoBehaviour
{

    public GameObject target;
    public float speed = 0.5f;

    private Vector3 startPosition;

    void Start(){
        startPosition = transform.position;
    }

    void Charge(){
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
    }

    
    void Update()
    {
        Charge();
        if (transform.position == target.transform.position){
            transform.position = startPosition;
        }
    }
}
