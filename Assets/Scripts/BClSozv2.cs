using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9;
    public GameObject b1, b2, b3, b4, b5, b6, b7, b8, b9;
    public Text txt;
    private int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        
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
        else if(i == 1)
        {
            b9.SetActive(true);
            txt.text = "Лев";
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
        btn8.SetActive(true);
        b6.SetActive(true);
    }
    public void BTN8()
    {
        btn9.SetActive(true);
        b7.SetActive(true);
    }
    public void BTN9()
    {
        b8.SetActive(true);
        i = 1;
    }
}
