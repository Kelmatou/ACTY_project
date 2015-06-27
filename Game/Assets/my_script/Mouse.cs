using UnityEngine;
using System.Collections;

public class Mouse : MonoBehaviour
{

    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;


    void Start()
    {
    }
    void Update()
    {
    }

    public void Enter()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }

    public void Exit()
    {
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }
    public void Click()
    {

        Application.OpenURL("file:///" + Application.streamingAssetsPath + "/main_page.html");
    }
}
