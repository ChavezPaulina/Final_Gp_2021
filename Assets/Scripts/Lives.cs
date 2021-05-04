using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    private Text LifeValue;
    private int LifeAmount;
    void Start()
    {
        LifeAmount = 0;
        LifeValue = GetComponent<Text>();
    }
    void Update()
    {
        LifeValue.text = LifeAmount.ToString();
    }
    public void AddLife()
    {
        LifeAmount += 1;
    }

    public void DecreaseLife()
    {
        LifeAmount -= 1;
    }
}
