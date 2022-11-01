using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ColorREd : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject GamegObgectToOriginal;
    public Button MyButton;
    void Start()
    {        
        Button btn = MyButton.GetComponent<Button>();
        Color OriginalColore = GamegObgectToOriginal.GetComponent<Renderer>().material.color;
        btn.onClick.AddListener(() => RetuernToOriginal(GamegObgectToOriginal, OriginalColore));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable()
    {
        
    }
    public void CubeActiveFunk(GameObject GameObgectToChnge)
    {
        GameObgectToChnge.GetComponent<CamraZoom>().enabled = true;
        GameObgectToChnge.GetComponent<CamraShke>().enabled = true;
        GameObgectToChnge.GetComponent<Acsident>().enabled = true;
        GameObgectToChnge.GetComponent<RotateCubeMuse>().enabled = true;
    }
    public void CubeDeactiveFunk(GameObject GameObgectToChnge)
    {
        GameObgectToChnge.GetComponent<CamraZoom>().enabled=false;
        GameObgectToChnge.GetComponent<CamraShke>().enabled = false;
        GameObgectToChnge.GetComponent<Acsident>().enabled = false;
        GameObgectToChnge.GetComponent<RotateCubeMuse>().enabled = false;
    }
    public void RetuernToOriginal(GameObject GameObgectToChnge,Color OriginalColor)
    {
        GameObgectToChnge.GetComponent<Renderer>().material.color = OriginalColor;
    }
    public void MyColorRed(GameObject GameObgectToChnge)
    {
         GameObgectToChnge.GetComponent<Renderer>().material.color=Color.red;
    }
}
