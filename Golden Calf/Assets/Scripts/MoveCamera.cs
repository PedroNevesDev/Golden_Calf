using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveCamera : MonoBehaviour
{
    
    Vector3 moving;
    Vector3 rotation;
    [SerializeField]Transform camPivot;


    [SerializeField] float rotationSpeed;
    [SerializeField] float movingSpeed;
    [SerializeField] float zoomSpeed;
    // Start is called before the first frame update

    public void StopMove()
    {
        moving = transform.position;
    }
    public void StopRotation()
    {
        rotation = new Vector3(0, 0, 0);
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
                camPivot.transform.position += moving * Time.deltaTime*movingSpeed;

        camPivot.transform.eulerAngles += new Vector3(0,0,0)+rotation*Time.deltaTime*rotationSpeed;

        camPivot.transform.position += new Vector3(0, -Input.mouseScrollDelta.y, 0)*Time.deltaTime*zoomSpeed;
    }
    void Update()
    {
        InputHandle();

    }
    void InputHandle()
    {

        moving = camPivot.right * Input.GetAxisRaw("Horizontal")+ camPivot.forward *Input.GetAxisRaw("Vertical") ;

        if (Input.GetKeyDown(KeyCode.Q))
        {
            rotation = new Vector3(0, 10, 0);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            rotation = new Vector3(0, - 10, 0);
        }

        HandleKeyReleases();
    }


    void HandleKeyReleases()
    {
       if(Input.GetKeyUp(KeyCode.Q))
            StopRotation();
       if (Input.GetKeyUp(KeyCode.E))
            StopRotation();
    }

}
