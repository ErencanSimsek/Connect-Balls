using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    [SerializeField]
    GameObject soundOn, soundOff;
    public static int Sound = 0;

    private void Start()
    {
        if (Sound == 0)
        {
            Music.Instance.gameObject.GetComponent<AudioSource>().enabled = true;
            soundOn.SetActive(true);
            soundOff.SetActive(false);
        }
        else if (Sound == 1)
        {
            Music.Instance.gameObject.GetComponent<AudioSource>().enabled = false;
            soundOff.SetActive(true);
            soundOn.SetActive(false);
        }
    }

    public void Play()
    {
        SceneManager.LoadScene("levelMenu");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void VolumeUp()
    {
        Music.Instance.gameObject.GetComponent<AudioSource>().enabled = false;
        soundOn.SetActive(false);
        soundOff.SetActive(true);
        Sound = 1;
    }

    public void SoundOff()
    {
        Music.Instance.gameObject.GetComponent<AudioSource>().enabled = true;
        soundOff.SetActive(false);
        soundOn.SetActive(true);
        Sound = 0;
    }
}
