using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1 : MonoBehaviour
{
    public void Information1()
    {
        SceneManager.LoadScene("information1");
        Music.Instance.gameObject.GetComponent<AudioSource>().enabled = false;
    }
    public void level1()
    {
        Time.timeScale = 1;
        Blue1.levelUp = 0;
        SceneManager.LoadScene("level1");
        Music.Instance.gameObject.GetComponent<AudioSource>().enabled = false;
    }
}
