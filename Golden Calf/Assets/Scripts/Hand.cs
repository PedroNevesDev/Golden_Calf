using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand: MonoBehaviour
{
    Vector3 pos;
    Vector3 startPos;
    [SerializeField] float slideUpValue;
    [SerializeField] float speed;



    void Start()
    {
        pos = transform.position;
        startPos = transform.position;

    }
    public void Enter()
    {
        if (transform.position.y < startPos.y + slideUpValue)
            pos = new Vector3(transform.position.x, transform.position.y + slideUpValue, transform.position.z);

    }
    public void Exit()
    {

        pos = startPos;

    }

    void FixedUpdate()
    {

        transform.position = Vector3.Lerp(transform.position,  pos,  Time.deltaTime * speed);


    }
}
