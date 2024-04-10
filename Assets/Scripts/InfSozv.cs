using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class InfSozv : MonoBehaviour
{
    public Image image, image1;
    public Sprite img, img1, img2, img3, img4, img5, img6, img7, img8, img9;
    [SerializeField] private Text txt1, txt2;
    private JsonFile file = new JsonFile();
    private string path;
    public GameObject but, but0, but1;
    public int i = 1;

    // Start is called before the first frame update
    void Start()
    {
        path = Application.streamingAssetsPath + "/" + "1.json";
        file = JsonUtility.FromJson<JsonFile>(File.ReadAllText(path));

        Pl();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Pl()
    {
        if(i == 1)
        {
            but0.SetActive(true);
            but1.SetActive(false);
            but.SetActive(true);
            image.sprite = img;
            image1.sprite = img1;
            txt1.text = file.Text.ToString();
            txt2.text = file.Text1.ToString();
        }
        else if(i == 2)
        {
            but1.SetActive(true);
            but0.SetActive(false);
            but.SetActive(true);
            image.sprite = img2;
            image1.sprite = img3;
            txt1.text = file.Text2.ToString();
            txt2.text = file.Text3.ToString();
        }
        else if(i == 3)
        {
            but1.SetActive(true);
            but0.SetActive(false);
            but.SetActive(true);
            image.sprite = img4;
            image1.sprite = img5;
            txt1.text = file.Text4.ToString();
            txt2.text = file.Text5.ToString();
        }
        else if(i == 4)
        {
            but1.SetActive(true);
            but0.SetActive(false);
            but.SetActive(true);
            image.sprite = img6;
            image1.sprite = img7;
            txt1.text = file.Text6.ToString();
            txt2.text = file.Text7.ToString();
        }
        else if(i == 5)
        {
            but1.SetActive(true);
            but0.SetActive(false);
            but.SetActive(false);
            image.sprite = img8;
            image1.sprite = img9;
            txt1.text = file.Text8.ToString();
            txt2.text = file.Text9.ToString();
        }
        i++;
    }

    public void B()
    {
        i--;
        Pl();
        i--;
    }

    public class JsonFile
    {
        public string Text, Text1, Text2, Text3, Text4, Text5, Text6, Text7, Text8, Text9;

    }
}
