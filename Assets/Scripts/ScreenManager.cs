using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    void Start()
    {
        Resolution maxRes = Screen.resolutions[Screen.resolutions.Length - 1];
        Screen.SetResolution(maxRes.width, maxRes.height, FullScreenMode.FullScreenWindow);
    }
}
