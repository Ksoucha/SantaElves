using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionScene : MonoBehaviour
{
    [SerializeField] Animator fadeToBlackAnimator;
    private bool isFadeAnimationOver = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            fadeToBlackAnimator.SetTrigger("FadeTrigger");
            isFadeAnimationOver = true;
        }

        if (isFadeAnimationOver)
        {
            StartCoroutine(LoadMainScene());
        }
    }

    IEnumerator LoadMainScene()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("MainScene");
    }
}
