using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    public GameObject startPanel;
    public GameObject endPanel;

    // Start is called before the first frame update
    void Start()
    {
        startPanel.SetActive(true);
        endPanel.SetActive(false);
    }

    public void Exit()
    {
        startPanel.SetActive(false);
        endPanel.SetActive(true);
    }

    public void No()
    {
        startPanel.SetActive(true);
        endPanel.SetActive(false);
    }

    public void Yes()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
