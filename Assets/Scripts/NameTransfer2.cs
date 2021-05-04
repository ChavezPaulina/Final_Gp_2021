using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameTransfer2 : MonoBehaviour
{
    public Text NameBox;

    void Start()
    {
        NameBox.text = PlayerPrefs.GetString("name");
    }

}
