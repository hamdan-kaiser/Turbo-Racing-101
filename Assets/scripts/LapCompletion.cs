using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class LapCompletion: MonoBehaviour
{
    public GameObject LapCompleteTrigger;
    public GameObject HalfLapTrigger;
    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MillSecondDisplay;
    public GameObject LapCounter;
    public GameObject LapFinishCounter;
    public GameObject Car;
    public GameObject Camera1;
    public GameObject Camera2;
     
    CountDown CountDown;
    public int LapDoneOk;

    public float RawTime;

    private void Start()
    {
        Camera1 = transform.Find("Car/Camera1").gameObject;
        Camera2 = transform.Find("Car/Camera2").gameObject;
    }

    private void OnTriggerEnter(Collider other)
    {

        RawTime = PlayerPrefs.GetFloat("RawTime");
        LapDoneOk += 1;
        if (LapTimeDisplayManager.RawTime <= RawTime)
        {

            
            if (LapTimeDisplayManager.SecondCount <= 9)
            {
                SecondDisplay.GetComponent<Text>().text = "0" + LapTimeDisplayManager.SecondCount + ".";
            }
            else
                SecondDisplay.GetComponent<Text>().text = "" + LapTimeDisplayManager.SecondCount + ".";

            if (LapTimeDisplayManager.MinuteCount <= 9)
            {
                MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeDisplayManager.MinuteCount + ".";
            }
            else
                MinuteDisplay.GetComponent<Text>().text = "" + LapTimeDisplayManager.MinuteCount + ".";


            MillSecondDisplay.GetComponent<Text>().text = "" + LapTimeDisplayManager.MillSecondCount;
        }


        PlayerPrefs.SetInt("MinSave", LapTimeDisplayManager.MinuteCount);
        PlayerPrefs.SetInt("SecSave", LapTimeDisplayManager.SecondCount);
        PlayerPrefs.SetFloat("MilliSave", LapTimeDisplayManager.MillSecondCount);
        PlayerPrefs.SetFloat("RawTime", LapTimeDisplayManager.RawTime);

        LapTimeDisplayManager.MinuteCount = 0;
        LapTimeDisplayManager.SecondCount = 0;
        LapTimeDisplayManager.MillSecondCount = 0;
        LapTimeDisplayManager.RawTime = 0;
        
        HalfLapTrigger.SetActive(true);
        LapCompleteTrigger.SetActive(false);

        if(LapCounter.GetComponent<Text>().text == "1")
        {
            Camera1.SetActive(false);
            Camera2.SetActive(true);
        }

        LapCounter.GetComponent<Text>().text = "" + LapDoneOk;



    }
    
           
      


}
