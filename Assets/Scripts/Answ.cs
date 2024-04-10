using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answ : MonoBehaviour
{
    public GameObject Q, Q1;
    public Text t;
    public Task task;
    public sc score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Check()

    {
        if(t.text == task.True)
        {
            t.text = t.text + "     +";
            StartCoroutine(Wait());
            score.i = score.i + 1;
        }
        else
        {
            t.text = t.text + "     -";
            StartCoroutine(Wait());
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        Q.SetActive(false);
        Q1.SetActive(true);
    }
}
