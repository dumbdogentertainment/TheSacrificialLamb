using UnityEngine;

public class InputController : MonoBehaviour
{
    public static InputController Instance = null;

    private void Awake()
    {
        DontDestroyOnLoad(this);

        Instance = this;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameManager.Instance.ToggleGamePause();
        }
    }

    public float GetHorizontalAxisInput()
    {
        float axisRaw = Input.GetAxisRaw("Horizontal");
        return axisRaw;
    }

    public float GetVerticalAxisInput()
    {
        float axisRaw = Input.GetAxisRaw("Vertical");
        return axisRaw;
    }
}