using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Button : MonoBehaviour
{
    [SerializeField]
    GameObject soundOn, soundOff, play, pause, pauseMenu, dieMenu, lifeMenu, levelMenu;
    [SerializeField]
    AudioSource inTheGame, PauseMenu;
    bool menu = false;

    private void Start()
    {
        if (Life.life != 0)
        {
            Time.timeScale = 1;
        }
        if (mainMenu.Sound == 0)
        {
            inTheGame.Play();
            PauseMenu.GetComponent<AudioSource>().enabled = true;
            soundOn.SetActive(true);
            soundOff.SetActive(false);
        }
        else if (mainMenu.Sound == 1)
        {
            inTheGame.GetComponent<AudioSource>().enabled = false;
            PauseMenu.GetComponent<AudioSource>().enabled = false;
            soundOff.SetActive(true);
            soundOn.SetActive(false);
        }
    }

    private void Update()
    {
        if (Life.life != 0 && Blue1.life == 0)
        {
            dieMenu.SetActive(true);
            play.SetActive(false);
            menu = true;
        }
        else if (Life.life == 0 && Blue1.life == 0)
        {
            OneHourDuration.StartTime = true;
            lifeMenu.SetActive(true);
            play.SetActive(false);
            menu = true;
        }

        if (Blue2.levelUp == 1)
        {
            levelMenu.SetActive(true);
            play.SetActive(false);
            menu = true;
        }
    }

    public void VolumeUp()
    {
        inTheGame.Pause();
        PauseMenu.GetComponent<AudioSource>().enabled = false;
        soundOn.SetActive(false);
        soundOff.SetActive(true);
        mainMenu.Sound = 1;
    }

    public void SoundOff()
    {
        if (menu == true)
        {
            inTheGame.GetComponent<AudioSource>().enabled = true;
            inTheGame.Pause();
            PauseMenu.GetComponent<AudioSource>().enabled = true;
            PauseMenu.Play();
        }
        else
        {
            inTheGame.GetComponent<AudioSource>().enabled = true;
            inTheGame.Play();
            PauseMenu.GetComponent<AudioSource>().enabled = true;
        }
        soundOff.SetActive(false);
        soundOn.SetActive(true);
        mainMenu.Sound = 0;
    }

    public void Play()
    {
        play.SetActive(false);
        pause.SetActive(true);
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        menu = true;
        if (mainMenu.Sound == 0)
        {
            inTheGame.Pause();
            PauseMenu.Play();
        }
    }

    public void Again()
    {
        Scene scene;
        scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        dieMenu.SetActive(false);
        Blue1.life = 1;
        Blue2.levelUp = 0;
        Time.timeScale = 1;
    }

    public void MenuPlay()
    {
        play.SetActive(true);
        pause.SetActive(false);
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        if (mainMenu.Sound == 0)
        {
            inTheGame.Play();
            PauseMenu.Pause();
        }
    }

    public void Exit()
    {
        dieMenu.SetActive(false);
        Blue1.life = 1;
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }

    public void Pause()
    {
        play.SetActive(true);
        pause.SetActive(false);
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        menu = false;
        if (mainMenu.Sound == 0)
        {
            inTheGame.Play();
            PauseMenu.Pause();
        }
    }
    
    public void LevelUp()
    {
        SceneManager.LoadScene("level3");
        Blue3.levelUp = 0;
    }
}
