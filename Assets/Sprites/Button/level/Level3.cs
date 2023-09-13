using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3 : MonoBehaviour
{
    public void level3()
    {
        Music.Instance.gameObject.GetComponent<AudioSource>().enabled = false;
        Time.timeScale = 1;
        Blue3.levelUp = 0;
        SceneManager.LoadScene("level3");
    }
}
