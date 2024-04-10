using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BClSozv1 : MonoBehaviour
{
    public GameObject btn2, btn3, btn4, btn5, btn6, btn7; 
    public GameObject b1, b2, b3, b4, b5, b6, b7;
    public GameObject p1, p2, next;
    public Text txt; 
    private int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        p1.SetActive(true);
        p2.SetActive(false);
        next.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BTN1()
    {
        btn2.SetActive(true);
    }
    public void BTN2()
    {
        btn3.SetActive(true);
        b1.SetActive(true);
    }
    public void BTN3()
    {
        btn4.SetActive(true);
        b2.SetActive(true);
    }
    public void BTN4()
    {
        if(i == 0)
        {
            btn5.SetActive(true);
            b3.SetActive(true);
        }
        else if (i == 1)
        {
            b7.SetActive(true);
            txt.text = "Большая Медведица";
            next.SetActive(true);
        }
    }
    public void BTN5()
    {
        btn6.SetActive(true);
        b4.SetActive(true);
    }
    public void BTN6()
    {
        btn7.SetActive(true);
        b5.SetActive(true);
    }
    public void BTN7()
    {
        b6.SetActive(true);
        i = 1;
    }

    public void Next()
    {
        p1.SetActive(false);
        p2.SetActive(true);
        next.SetActive(false);
        txt.text = " ";
    }
}
