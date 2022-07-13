using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    [SerializeField] VideoPlayer Vplayer;
    [SerializeField] GameObject background;
    [SerializeField] GameObject parent;
    public float countdown;
    bool countdownstart;
    // Start is called before the first frame update
    void Start()
    {
        countdown = 21f;
        parent.SetActive(true);
        Vplayer.Pause();
    }
    private void Update()
    {
        if (countdownstart)
        {
            if (countdown > 0f)
            {
                if (countdown < 17.25f)
                    parent.SetActive(false);
                countdown -= Time.deltaTime;

            }
            else
            {
                countdownstart = false;
                SceneManager.LoadScene(sceneName: "GameScreen");
            }
        }
    }

    public void StartGame()
    {
        background.SetActive(false);
        Vplayer.Play();
        countdownstart = true;
    }
}
