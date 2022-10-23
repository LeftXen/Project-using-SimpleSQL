using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimesCliked : MonoBehaviour
{
    private int timesClicked;

    // Update is called once per frame
    public void ClickMe()
    {
        timesClicked++;
    }

    public void DisplayClicks()
    {
        Debug.Log(timesClicked);
    }
}
