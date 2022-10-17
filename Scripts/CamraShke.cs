using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamraShke : MonoBehaviour
{
    Transform CamtraTransform;
    public float ShakeTime;
    public float ShkeRange;
    Vector3 originalPos;
    
    // Start is called before the first frame update
    void Start()
    {
        CamtraTransform = Camera.main.transform;
        originalPos = CamtraTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            StartCoroutine(CamraSaking()); 
        }
    }
    IEnumerator CamraSaking()
    {
        float elapseTime = 0;
        while(elapseTime< ShakeTime)
        {
             Vector3 pos = originalPos + Random.insideUnitSphere * ShkeRange;
           // Vector3 pos = new Vector3(Random.Range(originalPos.x + 2, originalPos.x - 2), Random.Range(originalPos.y + 2, originalPos.y - 2),0);
            pos.z = originalPos.z;
            CamtraTransform.position = pos;
            elapseTime += Time.deltaTime;
            yield return null;
        }
        CamtraTransform.position = originalPos;
    }
}
