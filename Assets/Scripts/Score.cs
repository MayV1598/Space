using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score:MonoBehaviour
{
    public TextAsset All, All1, All2, All3, All4, All5;
    public Text Tesk, a1, a2, a3, a4, a5,
        t, t1, t2, t3, t4, t5;

    // Start is called before the first frame update
    void Start()
    {
        string[] s = All.text.Split('/');
        string[] s1 = All1.text.Split('/');
        string[] s2 = All2.text.Split('/');
        string[] s3 = All3.text.Split('/');
        string[] s4 = All4.text.Split('/');
        string[] s5 = All5.text.Split('/');
        Tesk.text = s[0]; a1.text = s1[0]; a2.text = s2[0];
        a3.text = s3[0]; a4.text = s4[0]; a5.text = s5[0];
        t.text = s[2]; t1.text = s1[2]; t2.text = s2[2];
        t3.text = s3[2]; t4.text = s4[2]; t5.text = s5[2];
    }

    // Update is called once per frame
    void Update()
    {
    }
}
