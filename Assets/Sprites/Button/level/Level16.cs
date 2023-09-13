using UnityEngine;
using UnityEngine.SceneManagement;

public class Level16 : MonoBehaviour
{
    public void level16()
    {
        Music.Instance.gameObject.GetComponent<AudioSource>().enabled = false;
        Time.timeScale = 1;
        Blue15.levelUp = 0;
        SceneManager.LoadScene("level16");
    }
}
