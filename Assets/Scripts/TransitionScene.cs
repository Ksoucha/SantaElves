using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionScene : MonoBehaviour
{
    [SerializeField] Animator fadeToBlackAnimator;
    private bool isFadeAnimationOver = false;


    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            fadeToBlackAnimator.SetTrigger("FadeTrigger");
            isFadeAnimationOver = true;
        }

        if (isFadeAnimationOver)
        {
            SceneManager.LoadScene("MainScene");
        }
    }
}
