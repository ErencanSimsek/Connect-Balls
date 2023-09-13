using GoogleMobileAds.Api;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class level15Button : MonoBehaviour
{
    [SerializeField]
    GameObject Loading, ads, soundOn, soundOff, play, pause, pauseMenu, dieMenu, lifeMenu, levelMenu;
    [SerializeField]
    AudioSource inTheGame, PauseMenu;
    bool menu = false;
    [SerializeField]
    Image loadingImage;
    [Range(0, 1)]
    float progress = 0f;

    private void Start()
    {
        MobileAds.Initialize((InitializationStatus initStatus) => { });
        interAd();
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

        if (Blue15.levelUp == 1)
        {
            levelMenu.SetActive(true);
            play.SetActive(false);
            menu = true;
        }

        loadingImage.fillAmount = progress;
        progress += 0.003f;
        if (progress >= 1)
        {
            progress = 0;
        }

        if(ad != null && ad.CanShowAd())
        {
            Loading.SetActive(false);
            ads.SetActive(true);
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
        Blue15.levelUp = 0;
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

    InterstitialAd ad;
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-3940256099942544/1033173712";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-3940256099942544/4411468910";
#else
        string adUnitId = "unexpected_platform";
#endif
    void interAd()
    {
        if(ad != null)
        {
            ad.Destroy();
            ad = null;
        }

        var request = new AdRequest.Builder().Build();

        InterstitialAd.Load(adUnitId, request, (InterstitialAd ads, LoadAdError error) =>
          {
              if(error != null || ads == null)
              {

              }
              ad = ads;
              RegisterEventShader(ad);
          });
        
    }

    void RegisterEventShader(InterstitialAd ýnterstitial)
    {
        ýnterstitial.OnAdFullScreenContentOpened += () =>
        {
            PauseMenu.Pause();
            inTheGame.Pause();
        };
        ýnterstitial.OnAdFullScreenContentClosed += () =>
        {
            ad.Destroy();
            interAd();
            SceneManager.LoadScene("level16");
            Blue16.levelUp = 0;
        };

        ýnterstitial.OnAdFullScreenContentFailed += (AdError error) =>
         {
             interAd();
         };
    }

    public void LevelUp()
    {
        if (ad != null && ad.CanShowAd())
        {
            ad.Show();
        }
    }
}
