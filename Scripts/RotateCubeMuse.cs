using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCubeMuse : MonoBehaviour
{
    public float rorateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         //print( Input.GetAxis("Mouse X") );

    }
    private void OnMouseDrag()
    {
        float x = Input.GetAxis("Mouse X") * rorateSpeed;
        float y = Input.GetAxis("Mouse Y") * rorateSpeed;
        if(Input.GetMouseButton(1))
        {
            transform.Rotate(Vector3.down, x,Space.World);
            transform.Rotate(Vector3.right, y,Space.World);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            transform.rotation = Quaternion.Euler(0,0,0);
        }
        transform.Rotate(Vector3.down, x);
        transform.Rotate(Vector3.right, y);


    }
}
