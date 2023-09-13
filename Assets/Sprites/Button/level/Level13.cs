using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level13 : MonoBehaviour
{
    public void level13()
    {
        Music.Instance.gameObject.GetComponent<AudioSource>().enabled = false;
        Time.timeScale = 1;
        Blue13.levelUp = 0;
        SceneManager.LoadScene("level13");
    }
}
