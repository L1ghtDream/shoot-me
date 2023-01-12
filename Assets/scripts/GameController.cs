using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour{
    
    [SerializeField] private Texture2D cursorTexture;

    private static int FPS = 60;
    
    void Start(){
        //SetCursor();
        Application.targetFrameRate = FPS;
    }

    void Update(){
        
    }

    void SetCursor(){
        Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto);
    }
}
