using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreen : Screen
{
    public event Action PlayButtonClick;

    protected override void OnButtonClick()
    {
        PlayButtonClick?.Invoke();
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
