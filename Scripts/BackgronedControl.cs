using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BackgronedControl : MonoBehaviour
{
    // Start is called before the first frame update
    public MovingBackGrondObgect []MovingBackGrondObgect1;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        MovingBakGronedd(MovingBackGrondObgect1);
    }
  
    void MovingBakGronedd( MovingBackGrondObgect[] MovingBackGrondObgect1)
    {
        for (int i = 0; i < MovingBackGrondObgect1.Length; i++)
        {
            MovingBackGrondObgect1[i].BackGrondObgect.GetComponent<Renderer>().material.mainTextureOffset += new Vector2(MovingBackGrondObgect1[i].Xspeed, MovingBackGrondObgect1[i].Yspeed) * Time.deltaTime;
        }
    }

}
[System.Serializable]
public struct MovingBackGrondObgect
{
    public GameObject BackGrondObgect;
    public float Xspeed, Yspeed;
}
