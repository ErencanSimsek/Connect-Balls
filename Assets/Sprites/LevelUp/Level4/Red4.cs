using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red4 : MonoBehaviour
{
    [SerializeField]
    AudioSource Happy, Sad;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Blue")
        {
            Blue4.levelUp = 1;
            if (mainMenu.Sound == 0)
            {
                Happy.Play();
            }
            PlayerPrefs.SetString("level 5 active", "level 5 active");
        }
        if (collision.gameObject.tag == "finish")
        {
            Time.timeScale = 0;
            Life.life -= 1;
            Blue1.life -= 1;
            if (mainMenu.Sound == 0)
            {
                Sad.Play();
            }
        }
    }
}
