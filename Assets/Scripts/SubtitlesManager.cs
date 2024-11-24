using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SubtitlesManager : MonoBehaviour
{
    public Image subtitleBackground;
    public TMP_Text subtitleText;
    private float subtitleTimer;

    internal void ShowText(string text, float duration)
    {
        subtitleText.text = text;
        subtitleBackground.enabled = true;
        subtitleTimer = duration;
    }

    internal void ShowText(string text)
    {
        ShowText(text, text.Length * 0.15f);
    }

    private void Start()
    {
        ClearSubtitle();
    }

    private void ClearSubtitle()
    {
        subtitleBackground.enabled = false;
        subtitleText.text = "";
    }

    private void Update()
    {
        if (subtitleTimer > 0)
        {
            subtitleTimer -= Time.deltaTime;
            if (subtitleTimer <= 0)
            {
                ClearSubtitle();
            }
        }
    }
}
