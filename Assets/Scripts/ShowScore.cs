using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    public static int score = 0;

    public static int bestScore = 0;

    void Update()
    {
        GetComponent<Text>().text = score.ToString();
    }
}
