using System;
using System.Collections.Generic;
using UnityEngine;

public class myClock : MonoBehaviour
{
   //GameObjects



   public GameObject hourHand;
   public GameObject minuteHand;
   public GameObject secondHand;
   int lastSecond;
   
   void Start()
   {
    lastSecond = DateTime.Now.Second;
   } 

    void Update()
    {
        UpdateTimer();
    }

    void UpdateTimer()
    {
        int currentSecond = DateTime.Now.Second;
        if(currentSecond != lastSecond)
            {
                float secs = DateTime.Now.Second;
                float secsXRotation = (secs / 60f) * 360f;

                secondHand.transform.rotation = Quaternion.Euler(secsXRotation, 0, 0);
                float mins = DateTime.Now.Minute;
                float minsXRotation = (mins/60f) * 360f;

                minuteHand.transform.rotation = Quaternion.Euler(minsXRotation,0,0);
                float hrs = DateTime.Now.Hour % 12+(mins/60f) *30f;
                float hrsXRotation = (hrs/12f) * 360f ;

                hourHand.transform.rotation = Quaternion.Euler(hrsXRotation,0,0);
                lastSecond = currentSecond;



            }
    }


    // public void Update()
    // {
    //         DateTime currentTime = DateTime.Now;

    //         // Rotate the hour hand (360 degrees / 12 hours = 30 degrees per hour)
    //         float hourRotation = (currentTime.Hour % 12 + currentTime.Minute / 60f) * 30f;
    //         hourHand.localRotation = Quaternion.Euler(0, 0, -hourRotation);

    //         // Rotate the minute hand (360 degrees / 60 minutes = 6 degrees per minute)
    //         float minuteRotation = currentTime.Minute * 6f;
    //         minuteHand.localRotation = Quaternion.Euler(0, 0, -minuteRotation);

    //         // Rotate the second hand (360 degrees / 60 seconds = 6 degrees per second)
    //         float secondRotation = currentTime.Second * 6f;
    //         secondHand.localRotation = Quaternion.Euler(0, 0, -secondRotation);
    // }
}
