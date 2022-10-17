



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamraZoom : MonoBehaviour
{
    // Start is called before the first frame update
    float MinZoom2d=1;
    float MaxZoom2d=5;
    public int ZoomSpeed2d;
    float MinZoom3d = 20;
    float MaxZoom3d = 60;
    public int ZoomSpeed3d;
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        //Chek for 2d mode 
        if (Camera.main.orthographic)
        {
            Camera.main.orthographicSize=Mathf.Clamp(Camera.main.orthographicSize, MinZoom2d, MaxZoom2d);
            if(Input.GetAxis("Mouse ScrollWheel")>0|| Input.GetAxis("Vertical") > 0)
            {
                Camera.main.orthographicSize -= ZoomSpeed2d * Time.deltaTime;
            }
            if (Input.GetAxis("Mouse ScrollWheel") > 0|| Input.GetAxis("Vertical") < 0)
            {
                Camera.main.orthographicSize += ZoomSpeed2d * Time.deltaTime;
            }

        }
        else
        {
            Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView, MinZoom3d, MaxZoom3d);
            if (Input.GetAxis("Mouse ScrollWheel") > 0 || Input.GetAxis("Vertical") > 0)
            {
                Camera.main.fieldOfView -= ZoomSpeed3d * Time.deltaTime;
            }
            if (Input.GetAxis("Mouse ScrollWheel") > 0 || Input.GetAxis("Vertical") < 0)
            {
                Camera.main.fieldOfView += ZoomSpeed3d * Time.deltaTime;
            }
        }

    }
}
