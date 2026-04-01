using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameOverScreen : Screen
{
    public event Action RestartButtonClick;
    
    protected override void OnButtonClick()
    {
        RestartButtonClick?.Invoke();
    }

    public override void Open()
    {
        canvasGroup.alpha = 1;
        button.interactable = true;
    }

    public override void Close()
    {
        canvasGroup.alpha = 0;
        button.interactable = false;
    }
}
