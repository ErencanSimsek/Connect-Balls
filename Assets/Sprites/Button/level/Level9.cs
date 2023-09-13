using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level9 : MonoBehaviour
{
    public void level9()
    {
        Music.Instance.gameObject.GetComponent<AudioSource>().enabled = false;
        Time.timeScale = 1;
        Blue9.levelUp = 0;
        SceneManager.LoadScene("level9");
    }
}
