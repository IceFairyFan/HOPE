using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
//using GlobalVarList.x;

public class Card1DoubleClick : MonoBehaviour
{
    public GameObject Card1;

    float clicked = 0;
    float clicktime = 0;
    float clickdelay = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnPointerDown(PointerEventData data)
    {
        clicked++;
        if(clicked == 1)
        {
            clicktime = Time.time;
        }
        if(clicked > 1 && Time.time - clicktime < clickdelay)
        {
            clicked = 0;
            clicktime = 0;
            //Remove THIS Card1
            //x--;
            //Code enemy hit by x damage
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
