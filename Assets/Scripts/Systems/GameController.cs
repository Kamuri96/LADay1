using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    void Start()
    {
        // カーソルを非表示にする
        Cursor.visible = false;
        // カーソルが移動しないようにする
        Cursor.lockState = CursorLockMode.Locked;
    }
}
