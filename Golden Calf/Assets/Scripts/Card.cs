using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Card : MonoBehaviour
{
    Vector3 pos;
    Vector3 startPos;
    [SerializeField] float slideUpValue;
    [SerializeField] float speed;


    Vector3 startScale;
    Vector3 scale;
    bool followMouse;
    [SerializeField]float followMouseSpeed;

    void Start()
    {
        pos = transform.position;
        startPos = transform.position;
        startScale = transform.localScale;
        scale = transform.localScale;
    }
    public void Enter()
    {
        if(transform.position.y < startPos.y+slideUpValue)
            pos = new Vector3(transform.position.x, transform.position.y + slideUpValue, transform.position.z);

    }
    public void Exit()
    {

        pos = startPos;

    }
    public void BeginDrag()
    {
        followMouse = true;
        scale=transform.localScale/4;
    }
    public void EndDrag()
    {
        followMouse = false;
        scale = startScale;

    }
    void FixedUpdate()
    {

        transform.position = Vector3.Lerp(transform.position,followMouse?Input.mousePosition-new Vector3(-10,10,0):pos, followMouse ? Time.deltaTime * followMouseSpeed : Time.deltaTime * speed);
        transform.localScale = Vector3.Lerp(transform.localScale, scale, speed * Time.deltaTime);

    }
}
