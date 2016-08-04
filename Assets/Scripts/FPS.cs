using UnityEngine;

public class FPS : MonoBehaviour
{
    float deltaTime = 0.0f;

    void Awake()
    {
        //		// Limit the rate only in the Unity editor
        //		#if UNITY_EDITOR
        //		// vSync must be disabled to set target frame rate 0 for no sync, 1 for panel refresh rate, 2 for 1/2 panel rate
        //		QualitySettings.vSyncCount = 0; 
        //		// Setting targetFrameRate to -1 makes standalone games render as fast as they can, and web player games to render at 50-60 frames/second depending on the platform.
        //		Application.targetFrameRate = 60;
        //		#endif

    }

    void Update()
    {
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
    }

    void OnGUI()
    {
        int w = Screen.width, h = Screen.height;

        GUIStyle style = new GUIStyle();

        Rect rect = new Rect(0, 0, w, h * 2 / 100);
        style.alignment = TextAnchor.UpperLeft;
        style.fontSize = h * 2 / 100;
        //style.normal.textColor = new Color (0.0f, 0.0f, 0.5f, 1.0f);
        style.normal.textColor = Color.red;
        float msec = deltaTime * 1000.0f;
        float fps = 1.0f / deltaTime;
        string text = string.Format("development build- " + "{0:0.0} ms ({1:0.} fps)", msec, fps);
        GUI.Label(rect, text, style);
    }
}
