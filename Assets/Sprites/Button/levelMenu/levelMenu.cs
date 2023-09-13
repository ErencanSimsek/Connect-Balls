using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelMenu : MonoBehaviour
{
    public Button Level2, Level3, Level4, Level5, Level6, Level7, Level8, Level9, Level10;
    public Image Locked2, UnLocked2, Locked3, UnLocked3, Locked4, UnLocked4, Locked5, UnLocked5,
        Locked6, UnLocked6, Locked7, UnLocked7, Locked8, UnLocked8, Locked9, UnLocked9, Locked10, UnLocked10;
    [SerializeField]
    GameObject soundOn, soundOff;

    private void Start()
    {
        if (mainMenu.Sound == 0)
        {
            Music.Instance.gameObject.GetComponent<AudioSource>().enabled = true;
            soundOn.SetActive(true);
            soundOff.SetActive(false);
        }
        else if(mainMenu.Sound == 1)
        {
            Music.Instance.gameObject.GetComponent<AudioSource>().enabled = false;
            soundOff.SetActive(true);
            soundOn.SetActive(false);
        }
    }

    private void Update()
    {
        if (Blue1.levelUp == 1)
        {
            Level2.interactable = true;
            Locked2.enabled = false;
            UnLocked2.enabled = true;
            PlayerPrefs.SetString("level 2 active", "level 2 active");
        }
        if (Blue2.levelUp == 1)
        {
            Level3.interactable = true;
            Locked3.enabled = false;
            UnLocked3.enabled = true;
            PlayerPrefs.SetString("level 3 active", "level 3 active");
        }
        if (Blue3.levelUp == 1)
        {
            Level4.interactable = true;
            Locked4.enabled = false;
            UnLocked4.enabled = true;
            PlayerPrefs.SetString("level 4 active", "level 4 active");
        }
        if (Blue4.levelUp == 1)
        {
            Level5.interactable = true;
            Locked5.enabled = false;
            UnLocked5.enabled = true;
            PlayerPrefs.SetString("level 5 active", "level 5 active");
        }
        if (Blue5.levelUp == 1)
        {
            Level6.interactable = true;
            Locked6.enabled = false;
            UnLocked6.enabled = true;
            PlayerPrefs.SetString("level 6 active", "level 6 active");
        }
        if (Blue6.levelUp == 1)
        {
            Level7.interactable = true;
            Locked7.enabled = false;
            UnLocked7.enabled = true;
            PlayerPrefs.SetString("level 7 active", "level 7 active");
        }
        if (Blue7.levelUp == 1)
        {
            Level8.interactable = true;
            Locked8.enabled = false;
            UnLocked8.enabled = true;
            PlayerPrefs.SetString("level 8 active", "level 8 active");
        }
        if (Blue8.levelUp == 1)
        {
            Level9.interactable = true;
            Locked9.enabled = false;
            UnLocked9.enabled = true;
            PlayerPrefs.SetString("level 9 active", "level 9 active");
        }
        if (Blue9.levelUp == 1)
        {
            Level10.interactable = true;
            Locked10.enabled = false;
            UnLocked10.enabled = true;
            PlayerPrefs.SetString("level 10 active", "level 10 active");
        }
        if (PlayerPrefs.HasKey("level 2 active"))
        {
            Level2.interactable = true;
            Locked2.enabled = false;
            UnLocked2.enabled = true;
        }
        if (PlayerPrefs.HasKey("level 3 active"))
        {
            Level3.interactable = true;
            Locked3.enabled = false;
            UnLocked3.enabled = true;
        }
        if (PlayerPrefs.HasKey("level 4 active"))
        {
            Level4.interactable = true;
            Locked4.enabled = false;
            UnLocked4.enabled = true;
        }
        if (PlayerPrefs.HasKey("level 5 active"))
        {
            Level5.interactable = true;
            Locked5.enabled = false;
            UnLocked5.enabled = true;
        }
        if (PlayerPrefs.HasKey("level 6 active"))
        {
            Level6.interactable = true;
            Locked6.enabled = false;
            UnLocked6.enabled = true;
        }
        if (PlayerPrefs.HasKey("level 7 active"))
        {
            Level7.interactable = true;
            Locked7.enabled = false;
            UnLocked7.enabled = true;
        }
        if (PlayerPrefs.HasKey("level 8 active"))
        {
            Level8.interactable = true;
            Locked8.enabled = false;
            UnLocked8.enabled = true;
        }
        if (PlayerPrefs.HasKey("level 9 active"))
        {
            Level9.interactable = true;
            Locked9.enabled = false;
            UnLocked9.enabled = true;
        }
        if (PlayerPrefs.HasKey("level 10 active"))
        {
            Level10.interactable = true;
            Locked10.enabled = false;
            UnLocked10.enabled = true;
        }
    }

    public void VolumeUp()
    {
        Music.Instance.gameObject.GetComponent<AudioSource>().enabled = false;
        soundOn.SetActive(false);
        soundOff.SetActive(true);
        mainMenu.Sound = 1;
    }

    public void SoundOff()
    {
        Music.Instance.gameObject.GetComponent<AudioSource>().enabled = true;
        soundOff.SetActive(false);
        soundOn.SetActive(true);
        mainMenu.Sound = 0;
    }

    public void Forward()
    {
        SceneManager.LoadScene("levelMenu2");
    }

    public void Back()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
