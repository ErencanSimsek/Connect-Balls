using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Watch : MonoBehaviour
{
    [SerializeField]
    AudioSource PauseMenu, inTheGame;
    RewardedAd ad;
    [SerializeField]
    GameObject lifeMenu, Loading, ads;
    [SerializeField]
    Image loadingImage;
    [Range(0, 1)]
    float progress = 0f;

#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-3940256099942544/5224354917";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-3940256099942544/4411468910";
#else
        string adUnitId = "unexpected_platform";
#endif    
    void Start()
    {
        MobileAds.Initialize((InitializationStatus initStatus) => { });
        Rewarded();
    }

    void Rewarded()
    {
        if (ad != null)
        {
            ad.Destroy();
            ad = null;
        }

        var request = new AdRequest.Builder().Build();

        RewardedAd.Load(adUnitId, request, (RewardedAd ads, LoadAdError error) =>
        {
            if (error != null || ads == null)
            {

            }
            ad = ads;
            RegisterEventShader(ad);
        });
    }

    void RegisterEventShader(RewardedAd rewarded)
    {
        rewarded.OnAdFullScreenContentClosed += () =>
        {
            ad.Destroy();
            Rewarded();
        };

        rewarded.OnAdFullScreenContentFailed += (AdError error) =>
        {
            Rewarded();
        };
    }

    private void Update()
    {
        loadingImage.fillAmount = progress;
        progress += 0.003f;
        if (progress >= 1)
        {
            progress = 0;
        }

        if(ad != null == ad.CanShowAd())
        {
            Loading.SetActive(false);
            ads.SetActive(true);
        }
    }

    public void watch()
    {
        if (ad != null == ad.CanShowAd())
        {
            ad.Show((Reward reward) =>
            {
                string adsname = reward.Type;
                double amount = reward.Amount;
                PlayerPrefs.DeleteKey("life");
                OneHourDuration.LifeZero = false;
                Life.life = 3;
                Scene scene;
                scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(scene.name);
                lifeMenu.SetActive(false);
                Blue1.life = 1;
                Time.timeScale = 1;
            });
        }
    }
    
    public void Exit()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
