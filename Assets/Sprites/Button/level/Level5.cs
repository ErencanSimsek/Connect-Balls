using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level5 : MonoBehaviour
{
    public void level5()
    {
        Music.Instance.gameObject.GetComponent<AudioSource>().enabled = false;
        Time.timeScale = 1;
        Blue5.levelUp = 0;
        SceneManager.LoadScene("level5");
    }
}
