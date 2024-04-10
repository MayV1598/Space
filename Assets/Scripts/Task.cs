using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class Task : MonoBehaviour
{
    public TextAsset All;
    public string Text;
    public string TasK;
    public string Answers;
    public Text Tesk, a1, a2, a3;
    public string True;

    // Start is called before the first frame update
    void Start()
    {
        Text = All.text;
        string[] s = Text.Split('/');
        TasK = s[0];
        Answers = s[1];
        True = s[2];
        Tesk.text = TasK;
        string[] A = Answers.Split(";");
        a1.text = A[0];
        a2.text = A[1];
        a3.text = A[2];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
