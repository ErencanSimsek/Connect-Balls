using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level7 : MonoBehaviour
{
    public void level7()
    {
        Music.Instance.gameObject.GetComponent<AudioSource>().enabled = false;
        Time.timeScale = 1;
        Blue7.levelUp = 0;
        SceneManager.LoadScene("level7");
    }
}
