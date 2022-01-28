using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{

    private float slowdownValue = 0.05f;
    private float slowdownDuration = 10f;
    private float timer = 0f;
    private bool isActive = false;

    void Update()
    {
        //Kollar ifall tiden går långsamt
        //Ifall den gör det starta en timer
        if (isActive)
        {

            timer += Time.unscaledDeltaTime;

        
            //Om det har gått nog med tid
            //börja långsamt öka tidens hastighet
            //För att ge en "Smooth" upplevelse
            if (timer >= slowdownDuration)
            {
        
                Time.timeScale += 0.3f * Time.unscaledDeltaTime; 
                Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);

                //Om tiden är tillbaks till standard hastighet
                if (Time.timeScale == 1f)
                {

                    isActive = false;
                    timer = 0;

                }

            }

        }
    }

    public void SlowdownTime()
    {

        Time.timeScale = slowdownValue;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;

        isActive = true;

    }
}
