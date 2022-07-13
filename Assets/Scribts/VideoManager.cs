using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    [SerializeField] VideoPlayer Vplayer;
    [SerializeField] GameObject parent;
    public float countdown;
    bool countdownstart;
    // Start is called before the first frame update
    void Start()
    {
        countdown = 2.8f;
        parent.SetActive(true);
        Vplayer.Pause();
    }
    private void Update()
    {
        if (countdownstart)
        {
            if (countdown > 0) countdown -= Time.deltaTime;
            else
            {
                countdownstart = false;
                SceneManager.LoadScene(sceneName: "GameScreen");
            }
        }
    }

    public void StartGame()
    {
        parent.SetActive(false);
        Vplayer.Play();
        countdownstart = true;
    }
}
