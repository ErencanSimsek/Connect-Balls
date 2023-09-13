using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level4 : MonoBehaviour
{
    public void level4()
    {
        Music.Instance.gameObject.GetComponent<AudioSource>().enabled = false;
        Time.timeScale = 1;
        Blue4.levelUp = 0;
        SceneManager.LoadScene("level4");
    }
}
