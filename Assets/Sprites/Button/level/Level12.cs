using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level12 : MonoBehaviour
{
    public void level12()
    {
        Music.Instance.gameObject.GetComponent<AudioSource>().enabled = false;
        Time.timeScale = 1;
        Blue12.levelUp = 0;
        SceneManager.LoadScene("level12");
    }
}
