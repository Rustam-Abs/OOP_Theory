using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif


[DefaultExecutionOrder(-100)]
public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Canvas _startCanvas;
    [SerializeField]
    private Canvas _gameCanvas;
    public Canvas GameCanvas
        { get { return _gameCanvas; } }

    [SerializeField]
    private Canvas _pauseCanvas;

    public static GameManager instance;
    public enum GameState 
    {
        Start,
        Running,
        Pause
    }
    public GameState gameState = GameState.Start;

    private void Awake()
    {
       if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        _gameCanvas.enabled = false;
        _pauseCanvas.enabled = false;

       
    }


    private void Update()
    {
        if(gameState == GameState.Start &&  Input.GetKeyDown(KeyCode.Space))
        {
            BeginDemonstraion();

        }
        
        if(Input.GetKeyDown(KeyCode.Escape) && gameState== GameState.Start)
        {
            ExitApplication();

        }

        if(Input.GetKeyDown(KeyCode.Escape) && gameState != GameState.Start)
        {
            TogllePause();
        }        

    }



    private void BeginDemonstraion()
    {
        _startCanvas.enabled = false;
        _gameCanvas.enabled = true;
        gameState = GameState.Running;
    }


    public void TogllePause()
    {
        gameState = gameState == GameState.Pause? GameState.Running: GameState.Pause;
        Time.timeScale = gameState == GameState.Pause ? 0 : 1;
        _gameCanvas.enabled = gameState == GameState.Pause ? false : true;
        _pauseCanvas.enabled = gameState == GameState.Pause ? true : false;

    }


    public void ExitApplication()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

}
