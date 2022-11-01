using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acsident : MonoBehaviour
{
    // Start is called before the first frame update
    bool CamraCondition;
    CamraZoom CamraZoom;
    CamraShke CamraShke;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CamraCondition = Camera.main.orthographic;
        CamraZoom = GetComponent<CamraZoom>();
        CamraShke = GetComponent<CamraShke>();
        if (CamraCondition && Camera.main.orthographicSize<=1)
        {
            StartCoroutine(CamraShke.CamraSaking());
        }
       else if (CamraCondition==false && Camera.main.fieldOfView<=20)
        {
            print(20);
            StartCoroutine(CamraShke.CamraSaking());
        }


    }
}
