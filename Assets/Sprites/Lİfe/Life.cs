using UnityEngine;
using TMPro;

public class Life : MonoBehaviour
{
    [SerializeField]
    GameObject lifeMenu, Play;
    [SerializeField]
    AudioSource inTheGame, PauseMenu;
    public TMP_Text LifeText;
    public static int life = 3;

    private void Start()
    {
        if (PlayerPrefs.HasKey("life"))
        {
            life = PlayerPrefs.GetInt("life");
        }
        if (life <= 0)
        {
            Play.SetActive(false);
            Time.timeScale = 0;
            lifeMenu.SetActive(true);
            inTheGame.Pause();
            PauseMenu.Play();
            OneHourDuration.LifeZero = true;
        }
    }

    private void Update()
    {
        PlayerPrefs.SetInt(nameof(life), life);
        PlayerPrefs.Save();
        LifeText.text = PlayerPrefs.GetInt(nameof(life)).ToString();
    }
}
