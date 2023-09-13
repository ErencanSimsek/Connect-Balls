using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue1 : MonoBehaviour
{
    [SerializeField]
    AudioSource Happy, Sad;
    public static int levelUp = 0;
    public static int life = 1;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Red")
        {
            if(mainMenu.Sound == 0)
            {
                Happy.Play();
            }
            PlayerPrefs.SetString("level 2 active", "level 2 active");
            levelUp = 1;
        }
        if (collision.gameObject.tag == "finish")
        {
            if(mainMenu.Sound == 0)
            {
                Sad.Play();
            }
            Time.timeScale = 0;
            Life.life -= 1;
            life -= 1;
        }
    }
}
