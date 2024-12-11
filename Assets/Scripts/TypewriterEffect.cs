using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TypewriterEffect : MonoBehaviour
{

    [SerializeField] private float typewriterSpeed = 50f;

    public void Run(string textToType, TMP_Text textLabel)
    {
        StartCoroutine(TypeText(textToType, textLabel));
    
    }

    private IEnumerator TypeText(string textToType, TMP_Text textLabel)
    {

        textLabel.text = string.Empty;

        yield return new WaitForSeconds(0.5f);

        float time = 0;
        int charIndex = 0;

        while (charIndex < textToType.Length)
        {

            time += Time.deltaTime * typewriterSpeed;
            charIndex = Mathf.FloorToInt(time);
            charIndex = Mathf.Clamp(charIndex, 0, textToType.Length);

            textLabel.text = textToType.Substring(0, charIndex);

            yield return null;
        }

        textLabel.text = textToType;

    }



}
