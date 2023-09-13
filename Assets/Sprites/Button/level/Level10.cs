using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level10 : MonoBehaviour
{
    public void level10()
    {
        Music.Instance.gameObject.GetComponent<AudioSource>().enabled = false;
        Time.timeScale = 1;
        Blue10.levelUp = 0;
        SceneManager.LoadScene("level10");
    }
}
