using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelMenu2 : MonoBehaviour
{
    public Button Level11, Level12, Level13, Level14, Level15, Level16;
    public Image Locked11, UnLocked11, Locked12, UnLocked12, Locked13, UnLocked13, Locked14, UnLocked14, Locked15, UnLocked15, Locked16, UnLocked16;
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
        else if (mainMenu.Sound == 1)
        {
            Music.Instance.gameObject.GetComponent<AudioSource>().enabled = false;
            soundOff.SetActive(true);
            soundOn.SetActive(false);
        }
    }

    private void Update()
    {
        if(Blue10.levelUp == 1)
        {
            Level11.interactable = true;
            Locked11.enabled = false;
            UnLocked11.enabled = true;
            PlayerPrefs.SetString("level 11 active", "level 11 active");
        }
        if (Blue11.levelUp == 1)
        {
            Level12.interactable = true;
            Locked12.enabled = false;
            UnLocked12.enabled = true;
            PlayerPrefs.SetString("level 12 active", "level 12 active");
        }
        if (Blue12.levelUp == 1)
        {
            Level13.interactable = true;
            Locked13.enabled = false;
            UnLocked13.enabled = true;
            PlayerPrefs.SetString("level 13 active", "level 13 active");
        }
        if (Blue13.levelUp == 1)
        {
            Level14.interactable = true;
            Locked14.enabled = false;
            UnLocked14.enabled = true;
            PlayerPrefs.SetString("level 14 active", "level 14 active");
        }
        if (Blue14.levelUp == 1)
        {
            Level15.interactable = true;
            Locked15.enabled = false;
            UnLocked15.enabled = true;
            PlayerPrefs.SetString("level 15 active", "level 15 active");
        }
        if (Blue15.levelUp == 1)
        {
            Level16.interactable = true;
            Locked16.enabled = false;
            UnLocked16.enabled = true;
            PlayerPrefs.SetString("level 16 active", "level 16 active");
        }
        if (PlayerPrefs.HasKey("level 11 active"))
        {
            Level11.interactable = true;
            Locked11.enabled = false;
            UnLocked11.enabled = true;
        }
        if (PlayerPrefs.HasKey("level 12 active"))
        {
            Level12.interactable = true;
            Locked12.enabled = false;
            UnLocked12.enabled = true;
        }
        if (PlayerPrefs.HasKey("level 13 active"))
        {
            Level13.interactable = true;
            Locked13.enabled = false;
            UnLocked13.enabled = true;
        }
        if (PlayerPrefs.HasKey("level 14 active"))
        {
            Level14.interactable = true;
            Locked14.enabled = false;
            UnLocked14.enabled = true;
        }
        if (PlayerPrefs.HasKey("level 15 active"))
        {
            Level15.interactable = true;
            Locked15.enabled = false;
            UnLocked15.enabled = true;
        }
        if (PlayerPrefs.HasKey("level 16 active"))
        {
            Level16.interactable = true;
            Locked16.enabled = false;
            UnLocked16.enabled = true;
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

    public void Back()
    {
        SceneManager.LoadScene("levelMenu");
    }
}
