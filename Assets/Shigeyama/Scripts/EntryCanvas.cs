using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EntryCanvas : SingletonMonoBehaviour<EntryCanvas>
{
    [SerializeField]
    Text[] entryText = new Text[4];

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < entryText.Length; i++)
        {
            entryText[i].text = (i + 1).ToString() + "P : OUT";
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EntryDone(int entryNum)
    {
        entryText[entryNum].text = (entryNum + 1).ToString() + "P : IN";
    }

    public void EntryRelease(int arrayNum, int entryNum)
    {
        if (entryNum == -1)
        {
            entryText[arrayNum].text = (arrayNum + 1).ToString() + "P : OUT";
        }
        else
        {
            entryText[arrayNum].text = (arrayNum + 1).ToString() + "P : IN";
        }
    }
}
