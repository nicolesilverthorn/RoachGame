using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public enum GameStates
    {
        START,
        PLAYING,
        PAUSE,
        END
    };

    public GameStates mCurrState;
    
    void Start()
    {
        mCurrState = GameStates.START;
    }

    void Update()
    {
        switch (mCurrState)
        {
            case GameStates.START:
                UpdateStartState();
                break;

            case GameStates.PLAYING:
                UpdatePlayingState();
                break;

            case GameStates.PAUSE:
                UpdatePauseState();
                break;

            case GameStates.END:
                UpdateEndState();
                break;
        }
    }

    void UpdateStartState()
    {

        //mCurrState = GameStates.PLAYING;
    }

    void UpdatePlayingState()
    {

    }

    void UpdatePauseState()
    {

    }

    void UpdateEndState()
    {

    }
}
