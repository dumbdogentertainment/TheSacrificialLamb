using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;

    public bool IsGamePaused { get; private set; }

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
}
