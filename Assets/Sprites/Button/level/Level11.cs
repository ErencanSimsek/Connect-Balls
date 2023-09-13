using UnityEngine;
using UnityEngine.SceneManagement;

public class Level11 : MonoBehaviour
{
    public void information2()
    {
        Music.Instance.gameObject.GetComponent<AudioSource>().enabled = false;
        SceneManager.LoadScene("information2");
    }
    public void levelEleven()
    {
        Time.timeScale = 1;
        Blue11.levelUp = 0;
        SceneManager.LoadScene("level11");
    }
    public void level11()
    {
        Music.Instance.gameObject.GetComponent<AudioSource>().enabled = false;
        Time.timeScale = 1;
        Blue11.levelUp = 0;
        SceneManager.LoadScene("level11");
    }
}
