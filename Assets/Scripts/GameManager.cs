using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;

    public bool IsGamePaused { get; private set; }

    [SerializeField]
    private int Score;

    private void Awake()
    {
        DontDestroyOnLoad(this);

        Instance = this;
        this.IsGamePaused = false;
    }

    public virtual void ToggleGamePause()
    {
        this.IsGamePaused = !this.IsGamePaused;
        Time.timeScale = this.IsGamePaused ? 0f : 1f;
    }

    public virtual void GameWon()
    {
        this.IsGamePaused = true;

        // make YOU WIN panel active
    }

    public virtual void GameLost()
    {
        this.IsGamePaused = true;

        // make YOU LOSE panel active
    }

    public virtual void IncrementScore()
    {
        this.Score += 1;
    }
}
