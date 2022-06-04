using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    public enum GameState { play,end,wait};
    public GameState gameState;
    public static GameManager instance;
    private void Awake()
    {
        if (!instance) instance = this;
        else if (instance != this) Destroy(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void startPlay()
    {
        gameState = GameState.play;
    }
    public void looseGame()
    {
        gameState = GameState.end;
        Gameplay.Instance.finish();
        UiManager.instance.loose();
    }
    public void winGame()
    {
        UiManager.instance.win();

        gameState = GameState.end;
    }
}
