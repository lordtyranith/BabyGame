using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;


public class PicsHandler : MonoBehaviour
{
    public List<string> Pics;
    int NumberOfPics = 82;
    [SerializeField] Image MainFrame;
    string pathPics = "Fotos/";
    int tagRef = 0;
    private void Start()
    {
        for (int i = 0; i < NumberOfPics; i++)
        {
            Pics.Add(i.ToString());
        }
        Pics = Pics.OrderBy(tvz => System.Guid.NewGuid()).ToList();
        RandomNextPic(0);
    }


    public void RandomNextPic(int num)
    {
        tagRef = tagRef + num;
        MainFrame.sprite = Resources.Load<Sprite>(pathPics + Pics[tagRef]);
        if (tagRef == 82)
        {
            Pics = Pics.OrderBy(tvz => System.Guid.NewGuid()).ToList();
            tagRef = 0;
        }
    }

}
