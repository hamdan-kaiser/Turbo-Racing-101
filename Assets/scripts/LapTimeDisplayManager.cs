using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeDisplayManager : MonoBehaviour
{
    public static int MinuteCount;
    public static int SecondCount;
    public static float MillSecondCount;

    //for display.....

    public static string MilliDisplay;

    //Drag & Drop Minute, Second, and Millisecond here....

    public GameObject MinuteBox;
    public GameObject SecondBox;
    public GameObject MillSecondBox;


    public static float RawTime;

    private void Update()
    {
        MillSecondCount += Time.deltaTime * 10;

        RawTime += Time.deltaTime;
        MilliDisplay = MillSecondCount.ToString("f0");
        MillSecondBox.GetComponent<Text>().text = "0" + MilliDisplay;

        if(MillSecondCount >= 10)
        {
            MillSecondCount = 0;
            SecondCount += 1;
        }

        
            SecondBox.GetComponent<Text>().text = "" + SecondCount + ".";
       

        if(SecondCount >= 60)
        {
            SecondCount = 0;
            MinuteCount += 1;

           
        }

        
            MinuteBox.GetComponent<Text>().text = "" + MinuteCount + ":";
        

    }
}
