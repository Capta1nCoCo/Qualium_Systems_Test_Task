using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{
    [SerializeField] GameObject startCanvas;
    [SerializeField] GameObject restartCanvas;
    [SerializeField] GameObject directionalLight;

    TimerController timerController;

    private void Awake()
    {        
        Time.timeScale = 0;
        timerController = FindObjectOfType<TimerController>();
        startCanvas.SetActive(true);
        directionalLight.SetActive(false);
        restartCanvas.SetActive(false);
    }

    public void StartGame()
    {
        startCanvas.SetActive(false);
        directionalLight.SetActive(true);
        Time.timeScale = 1;
        timerController.BeginTimer();
    }

    public void EndGame()
    {
        restartCanvas.SetActive(true);
        directionalLight.SetActive(false);
        Time.timeScale = 0;
        timerController.StopTimer();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
