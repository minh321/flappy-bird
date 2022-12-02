using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverCanvas;
    [SerializeField] private GameObject gameScene;
    public static GameManager instance { get; set; }
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    
    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        gameScene.SetActive(false);
        
    }
    public void restartGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void OnShowMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
