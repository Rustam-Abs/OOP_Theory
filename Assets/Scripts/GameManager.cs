using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(-100)]
public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Canvas _startCanvas;
    [SerializeField]
    private Canvas _gameCanvas;

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

       
    }


    private void Update()
    {
        if(gameState == GameState.Start &&  Input.GetKeyDown(KeyCode.Space))
        {
            BeginDemonstraion();
        }
        
    }



    private void BeginDemonstraion()
    {
        _startCanvas.enabled = false;
        _gameCanvas.enabled = true;
    }


}
