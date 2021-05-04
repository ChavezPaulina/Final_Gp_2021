using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    private Text PointValue;
    private int PointAmount;
    void Start()
    {
        PointAmount = 0;
        PointValue = GetComponent<Text>();
    }
    void Update()
    {
        PointValue.text = PointAmount.ToString();
    }
    public void AddPoint()
    {
        PointAmount += 1;
    }

    public void DecreasePoint()
    {
        PointAmount -= 1;
    }
}
