using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class InfPlanet : MonoBehaviour
{
    public int img;
    public Image image, image1, image0, image2, im, im1, im2;
    public Sprite imgPl0;
    public Sprite imgPl1;
    public Sprite imgPl2;
    public Sprite imgPl3, imgSP31;
    public Sprite imgPl4, imgSP41, imgSP42;
    public Sprite imgPl5, imgSP51, imgSP52, imgSP53, imgSP54, imgSP55;
    public Sprite imgPl6, imgSP61, imgSP62, imgSP63, imgSP64, imgSP65, imgSP66, imgSP67, imgSP68;
    public Sprite imgPl7;
    public Sprite imgPl8;
    public Sprite imgPl9, imgSP91, imgSP92, imgSP93, imgSP94, imgSP95;
    [SerializeField] private Text txt, txt0, txt1, txt2, t, t1, t2;
    private JsonFile file = new JsonFile();
    private string path;
    public GameObject but, but1, but0, but2;
    public GameObject pn1, pn2, pn3, pn4;
    private int i = 1;

    // Start is called before the first frame update
    void Start()
    {
        path = Application.streamingAssetsPath + "/" + "0.json";
        file = JsonUtility.FromJson<JsonFile>(File.ReadAllText(path));

        img = forPlanet.img;
        Pl();
    }

    public void Sp()
    {
        if(img == 3)
        {
            but0.SetActive(false);
            but1.SetActive(true);
            but.SetActive(false);
            image.sprite = imgSP31;
            txt.text = file.Text31.ToString();
        }

        if(img == 4)
        {
            pn1.SetActive(false);
            pn2.SetActive(true);
            but2.SetActive(false);
            image0.sprite = imgSP41;
            image1.sprite = imgSP42;
            txt0.text = file.Text41.ToString();
            txt1.text = file.Text42.ToString();
        }

        if(img == 5)
        {
            pn1.SetActive(false);
            if(i == 1)
            {
                pn3.SetActive(true);
                image2.sprite = imgSP51;
                txt2.text = file.Text51.ToString();
                i++;
            }
            else if(i == 2)
            {
                pn3.SetActive(false);
                pn2.SetActive(true);
                but2.SetActive(true);
                image0.sprite = imgSP52;
                image1.sprite = imgSP53;
                txt0.text = file.Text52.ToString();
                txt1.text = file.Text53.ToString();
                i++;
            }
            else if(i == 3)
            {
                pn3.SetActive(false);
                pn2.SetActive(true);
                but2.SetActive(false);
                image0.sprite = imgSP54;
                image1.sprite = imgSP55;
                txt0.text = file.Text54.ToString();
                txt1.text = file.Text55.ToString();
                i++;
            }
        }

        if(img == 6)
        {
            pn1.SetActive(false);
            pn3.SetActive(false);
            if(i == 1)
            {
                pn2.SetActive(true);
                but2.SetActive(true);
                image0.sprite = imgSP61;
                image1.sprite = imgSP62;
                txt0.text = file.Text61.ToString();
                txt1.text = file.Text62.ToString();
                i++;
            }
            else if(i == 2)
            {
                pn2.SetActive(true);
                but2.SetActive(true);
                image0.sprite = imgSP63;
                image1.sprite = imgSP64;
                txt0.text = file.Text63.ToString();
                txt1.text = file.Text64.ToString();
                i++;
            }
            else if(i == 3)
            {
                pn2.SetActive(true);
                but2.SetActive(true);
                image0.sprite = imgSP65;
                image1.sprite = imgSP66;
                txt0.text = file.Text65.ToString();
                txt1.text = file.Text66.ToString();
                i++;
            }
            else if(i == 4)
            {
                pn2.SetActive(true);
                but2.SetActive(false);
                image0.sprite = imgSP67;
                image1.sprite = imgSP68;
                txt0.text = file.Text67.ToString();
                txt1.text = file.Text68.ToString();
                i++;
            }
        }

        if(img == 9)
        {
            pn1.SetActive(false);
            if(i == 1)
            {
                pn4.SetActive(false);
                pn2.SetActive(true);
                but2.SetActive(true);
                image0.sprite = imgSP91;
                image1.sprite = imgSP92;
                txt0.text = file.Text91.ToString();
                txt1.text = file.Text92.ToString();
                i++;
            }
            else if(i == 2)
            {
                pn4.SetActive(true);
                pn2.SetActive(false);
                im.sprite = imgSP93;
                im1.sprite = imgSP94;
                im2.sprite = imgSP95;
                t.text = file.Text93.ToString();
                t1.text = file.Text94.ToString();
                t2.text = file.Text95.ToString();
                i++;
            }
        }
    }

    public void Pl()
    {
        pn1.SetActive(true);
        pn2.SetActive(false);
        pn3.SetActive(false);
        pn4.SetActive(false);
        but1.SetActive(false);
        but0.SetActive(true);

        i--;
        if(i <= 1)
        {
            i = 1;
            if(img == 0)
            {
                but.SetActive(false);
                image.sprite = imgPl0;
                txt.text = file.Text.ToString();
            }

            if(img == 1)
            {
                but.SetActive(false);
                image.sprite = imgPl1;
                txt.text = file.Text1.ToString();
            }

            if(img == 2)
            {
                but.SetActive(false);
                image.sprite = imgPl2;
                txt.text = file.Text2.ToString();
            }

            if(img == 3)
            {
                but.SetActive(true);
                image.sprite = imgPl3;
                txt.text = file.Text3.ToString();
            }

            if(img == 4)
            {
                but.SetActive(true);
                image.sprite = imgPl4;
                txt.text = file.Text4.ToString();
            }

            if(img == 5)
            {
                but.SetActive(true);
                image.sprite = imgPl5;
                txt.text = file.Text5.ToString();
            }

            if(img == 6)
            {
                but.SetActive(true);
                image.sprite = imgPl6;
                txt.text = file.Text6.ToString();
            }

            if(img == 7)
            {
                but.SetActive(false);
                image.sprite = imgPl7;
                txt.text = file.Text7.ToString();
            }

            if(img == 8)
            {
                but.SetActive(false);
                image.sprite = imgPl8;
                txt.text = file.Text8.ToString();
            }

            if(img == 9)
            {
                but.SetActive(true);
                image.sprite = imgPl9;
                txt.text = file.Text9.ToString();
            }
        }
        else
        {
            i--;
            Sp();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class JsonFile
{
    public string Text, Text1, Text2, Text3, Text31, Text4, Text41, Text42, Text5, Text51, Text52, Text53, Text54, Text55, Text6, 
        Text61, Text62, Text63, Text64, Text65, Text66, Text67, Text68, Text7, Text8, Text9, Text91, Text92, Text93, Text94, Text95;

}
