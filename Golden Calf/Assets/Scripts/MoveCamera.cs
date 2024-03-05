using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveCamera : MonoBehaviour
{
    
    Vector3 moving;
    [SerializeField]Transform camPivot;


    [SerializeField] float rotationSpeed;
    [SerializeField] float movingSpeed;
    [SerializeField] float zoomSpeed;
    // Start is called before the first frame update

    public void StopMove()
    {
        moving = transform.position;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        camPivot.transform.position = Vector3.Lerp(camPivot.transform.position, camPivot.transform.position +moving,movingSpeed*Time.deltaTime);

        camPivot.transform.eulerAngles += new Vector3(0, Input.GetAxisRaw("Diagonal"), 0)*rotationSpeed*Time.deltaTime*rotationSpeed;
        camPivot.transform.position += new Vector3(0, -Input.mouseScrollDelta.y, 0) * Time.deltaTime * zoomSpeed;

    }
    void Update()
    {
        InputHandle();

    }
    void InputHandle()
    {

        moving = camPivot.right * Input.GetAxisRaw("Horizontal")+ camPivot.forward *Input.GetAxisRaw("Vertical") ;

    }

}



