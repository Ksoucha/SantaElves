using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SubtitlesManager : MonoBehaviour
{
    public Image subtitleBackgroundImage;
    public Image gameControlsBackgroundImage;

    public TMP_Text subtitleText;
    public TMP_Text gameControlsText;

    private float subtitleTimer;
    private float gameControlsTextTimer = 15f;

    internal void ShowSubtitleText(string text, float duration)
    {
        subtitleText.text = text;
        subtitleBackgroundImage.enabled = true;
        subtitleTimer = duration;
    }

    internal void ShowGameControlsText(string text, float duration)
    {
        gameControlsText.text = text;
        gameControlsBackgroundImage.enabled = true;
        gameControlsTextTimer = duration;
    }

    internal void ShowSubtitleText(string text)
    {
        ShowSubtitleText(text, text.Length * 0.15f);
    }

    private void Start()
    {
        //ClearSubtitle();
        ShowGameControlsText(gameControlsText.text, 15f);
    }

    private void ClearGameControlsText()
    {
        gameControlsBackgroundImage.enabled = false;
    }

    private void ClearSubtitle()
    {
        subtitleBackgroundImage.enabled = false;
        subtitleText.text = "";
    }

    private void Update()
    {
        if (subtitleTimer > 0)
        {
            subtitleTimer -= Time.deltaTime;
            if (subtitleTimer <= 0)
            {
                //ClearSubtitle();
            }
        }

        if (gameControlsTextTimer > 0)
        {
            subtitleTimer -= Time.deltaTime;
            if (subtitleTimer <= 0)
            {
                ClearGameControlsText();
            }
        }
    }
}
