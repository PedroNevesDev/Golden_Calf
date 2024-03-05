using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;


public class Hex : MonoBehaviour
{
    [SerializeField]GameObject hexUi;
    [SerializeField] float slideUpValue;
    Vector3 pos;
    Vector3 startPos;
    Animator aniUI;
    Animator thisAni;

    bool activated=false;
    // Start is called before the first frame update
    void Start()
    {
        aniUI = hexUi.GetComponent<Animator>();
        thisAni = GetComponent<Animator>();
        pos= transform.position;
        startPos = transform.position;
    }

    // Update is called once per frame
    public void OnMouseEnter()
    {
        aniUI.SetTrigger("Activated");
        //thisAni.SetTrigger("Activated");
        activated = true;
        pos = new Vector3(transform.position.x, transform.position.y + slideUpValue, transform.position.z);
            
    }
    public void OnMouseExit()
    {
        aniUI.SetTrigger("Diactivated");
        //thisAni.SetTrigger("Diactivated");
        activated = false;
        pos = startPos;
    }
    void FixedUpdate()
    {
            transform.position = Vector3.Lerp(transform.position,pos,4*Time.deltaTime);
    }


}
