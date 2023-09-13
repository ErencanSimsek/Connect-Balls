using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OneHourDuration : MonoBehaviour
{
    [SerializeField]
    Text HourText, MinuteText, SecondText;
    [SerializeField]
    GameObject lifeMenu;
    public static bool StartTime = false, LifeZero = false;
    public static float Second = 0;
    int Hour = 1, Minute = 0;

    private void Start()
    {
        if(LifeZero == true)
        {
            if (PlayerPrefs.HasKey("Hour"))
            {
                Hour = PlayerPrefs.GetInt("Hour");
            }
            if (PlayerPrefs.HasKey("Minute"))
            {
                Minute = PlayerPrefs.GetInt("Minute");
            }
            if (PlayerPrefs.HasKey("Second"))
            {
                Second = PlayerPrefs.GetFloat("Second");
            }
        }
    }

    private void Update()
    {
        if(LifeZero == true)
        {
            SecondFunction();
        }

        if(StartTime == true)
        {
            StartFunction();
        }
    }

    void StartFunction()
    {
        HourText.text = "0" + Hour;
        if (Hour <= 0)
        {
            Hour = 0;
            HourText.text = Hour + "0";
            SecondFunction();
        }
        else if (Hour > 0)
        {
            Hour -= 1;
            Second = 60;
            SecondText.text = Second + "";
            Minute = 15;
        }
    }
    void SecondFunction()
    {
        PlayerPrefs.SetInt("Hour", Hour);
        PlayerPrefs.SetInt("Minute", Minute);
        PlayerPrefs.SetFloat("Second", Second);
        Second -= Time.unscaledDeltaTime;
        if (Second >= 10)
        {
            SecondText.text = (int)Second + "";
        }
        else if (Second < 10)
        {
            SecondText.text = "0" + (int)Second;
        }

        if (Minute >= 10)
        {
            MinuteText.text = Minute + "";
        }
        else if (Minute < 10)
        {
            MinuteText.text = "0" + Minute;
        }

        if (Second <= 0)
        {
            if (Minute != 0)
            {
                Minute -= 1;
                if (Minute >= 10)
                {
                    MinuteText.text = Minute + "";
                }
                else if (Minute < 10)
                {
                    MinuteText.text = "0" + Minute;
                }
                Second = 60;
            }
            else if (Minute == 0)
            {
                PlayerPrefs.DeleteKey("Second");
                PlayerPrefs.DeleteKey("Hour");
                PlayerPrefs.DeleteKey("Minute");
                StartTime = false;
                LifeZero = false;
                PlayerPrefs.DeleteKey("life");
                Life.life = 3;
                Scene scene;
                scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(scene.name);
                lifeMenu.SetActive(false);
                Blue1.life = 1;
                Time.timeScale = 1;
            }
        }
    }
}