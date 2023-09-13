using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level14 : MonoBehaviour
{
    public void level14()
    {
        Music.Instance.gameObject.GetComponent<AudioSource>().enabled = false;
        Time.timeScale = 1;
        Blue14.levelUp = 0;
        SceneManager.LoadScene("level14");
    }
}
