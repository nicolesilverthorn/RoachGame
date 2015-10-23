using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public enum GameStates
    {
        PLAYING,
        START,
        END,
        PAUSE
    };

    public GameStates mCurrState;

    //public GameObject mTopBoundary;
    //public GameObject mBottomBoundary;
    //public GameObject mLeftBoundary;
    //public GameObject mRightBoundary;

    //public GameObject mPlayer;

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
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            mCurrState = GameStates.PLAYING;
            mPlayer.GetComponent<PlayerDataSpace>().mPlayerState = PlayerDataSpace.PlayerState.DEFAULT;
        }*/
    }

    //private int enemyCount_ = 0;
    //private float spawnTimer_ = 0.0f;
    public float mCurrDifficulty = 0.000f;

    void UpdatePlayingState()
    {
        /*UpdateGameBoundaries();

        spawnTimer_ += Time.deltaTime;

        if (spawnTimer_ > 0.5f)
        {
            float rand = Random.Range(0.0f, 1.0f);
            if (rand > 1.0f - mCurrDifficulty)
            {
                //GetComponent<Spawn>().SpawnShip();
                spawnTimer_ = 0.0f;
                enemyCount_++;

                if (enemyCount_ > 10)
                {
                    mCurrDifficulty += 0.001f;
                    enemyCount_ = 0;
                }
            }
        }*/
    }

    void UpdatePauseState()
    {

    }

    void UpdateEndState()
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            int enemyCount_ = 0;
            float spawnTimer_ = 0.0f;
            float mCurrDifficulty = 0.01f;
            mPlayer.transform.position = Vector3.zero;
            mPlayer.SetActive(true);
            //clear enemies:
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
            for (int i = 0; i < enemies.Length; ++i)
            {
                GameObject.Destroy(enemies[i]);
            }
            mCurrState = GameStates.PLAYING;
            //mPlayer.GetComponent<PlayerDataSpace>().mPlayerState = PlayerDataSpace.PlayerState.DEFAULT;
        }*/
    }

/*    void OnGUI()
    {
        switch (mCurrState)
        {
            case GameStates.START:
                OnGUIStartState();
                break;

            case GameStates.PLAYING:
                OnGUIPlayingState();
                break;

            case GameStates.PAUSE:
                OnGUIPauseState();
                break;

            case GameStates.END:
                OnGUIEndState();
                break;
        }
    }

    void OnGUIStartState()
    {
        GUI.Label(GetScreenCoords(START_LABEL_X, START_LABEL_Y, START_LABEL_WIDTH, START_LABEL_HEIGHT), START_LABEL_TEXT);
    }

    void OnGUIPlayingState()
    {

    }

    void OnGUIPauseState()
    {

    }

    void OnGUIEndState()
    {
        GUI.Label(GetScreenCoords(START_LABEL_X, START_LABEL_Y, START_LABEL_WIDTH, START_LABEL_HEIGHT), END_LABEL_TEXT);
    }
    
    //takes x, y, width, height (in default screen size coords) and generates a new position rect given the actual screen size
    Rect GetScreenCoords(int posX, int posY, int width, int height)
    {
        float widthRatio = (float)posX / (float)DEFAULT_SCREEN_WIDTH;
        float heightRatio = (float)posY / (float)DEFAULT_SCREEN_HEIGHT;

        return new Rect(Screen.width * widthRatio, Screen.height * heightRatio, width * widthRatio, height * heightRatio);
    }

    void UpdateGameBoundaries()
    {
        float top, left, right, bottom;

        top = Camera.main.orthographicSize;
        bottom = -top;
        right = Camera.main.orthographicSize * Camera.main.aspect;
        left = -right;

        Vector3 temp = mTopBoundary.transform.position;
        temp.y = top;
        mTopBoundary.transform.position = temp;
        temp = mTopBoundary.transform.localScale;
        temp.x = (right - left);
        mTopBoundary.transform.localScale = temp;

        temp = mLeftBoundary.transform.position;
        temp.x = left;
        mLeftBoundary.transform.position = temp;
        temp = mLeftBoundary.transform.localScale;
        temp.y = (right - left);
        mLeftBoundary.transform.localScale = temp;

        temp = mRightBoundary.transform.position;
        temp.x = right;
        mRightBoundary.transform.position = temp;
        temp = mRightBoundary.transform.localScale;
        temp.y = (right - left);
        mRightBoundary.transform.localScale = temp;

        temp = mBottomBoundary.transform.position;
        temp.y = bottom;
        mBottomBoundary.transform.position = temp;
        temp = mBottomBoundary.transform.localScale;
        temp.x = (right - left);
        mBottomBoundary.transform.localScale = temp;
    }*/
}
