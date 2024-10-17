using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointCounter : MonoBehaviour
{

    public static PointCounter instance;
    public TMP_Text pointText;
    public int currentPoints = 0;

    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        pointText.text = "POINTS: " + currentPoints.ToString();
    }

    public void IncreasePoints(int v)
    {
        currentPoints += v;
        pointText.text = "POINTS: " + currentPoints.ToString() + "/10";

    }
}
