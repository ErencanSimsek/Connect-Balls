using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2 : MonoBehaviour
{
    public void level2()
    {
        Music.Instance.gameObject.GetComponent<AudioSource>().enabled = false;
        Time.timeScale = 1;
        Blue2.levelUp = 0;
        SceneManager.LoadScene("level2");
    }
}
