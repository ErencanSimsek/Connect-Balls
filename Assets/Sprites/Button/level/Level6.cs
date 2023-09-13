using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level6 : MonoBehaviour
{
    public void level6()
    {
        Music.Instance.gameObject.GetComponent<AudioSource>().enabled = false;
        Time.timeScale = 1;
        Blue6.levelUp = 0;
        SceneManager.LoadScene("level6");
    }
}
