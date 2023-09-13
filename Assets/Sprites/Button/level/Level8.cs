using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level8 : MonoBehaviour
{
    public void level8()
    {
        Music.Instance.gameObject.GetComponent<AudioSource>().enabled = false;
        Time.timeScale = 1;
        Blue8.levelUp = 0;
        SceneManager.LoadScene("level8");
    }
}
