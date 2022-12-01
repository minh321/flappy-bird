using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject MainMenuCanvas;
    public GameObject gameScene;
    // Start is called before the first frame update
    void Start()
    {
        //MainMenuCanvas.SetActive(true);
        OnShowMenu();
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameOver()
    {
        StartCoroutine(gameOverDelay(2f));
    }
    public void PlayGame()
    {
        gameScene.SetActive(true);
        MainMenuCanvas.SetActive(false);
        gameOverCanvas.SetActive(false);
        Time.timeScale = 1;
    }
    public void OnShowMenu()
    {
        gameScene.SetActive(false);
        MainMenuCanvas.SetActive(true);
        gameOverCanvas.SetActive(false);
    }
    private IEnumerator gameOverDelay(float waitTime)
    {
        gameOverCanvas.SetActive(true);
        gameScene.SetActive(false);
        yield return new WaitForSeconds(waitTime);
        Time.timeScale = 0;
    }
}
