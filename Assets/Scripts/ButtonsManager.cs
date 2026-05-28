using UnityEngine;
using System.Collections;

public class ButtonsManager : MonoBehaviour
{
    [SerializeField]
    private Animator[] songButtons;
    [SerializeField]
    private Animator closeButton; 
    [SerializeField]
    private float timeBetweenButtons = 0.1f;
    [SerializeField]
    private string ShowAnimationName = "Show";
    [SerializeField]
    private string hideAnimationName = "Hide";
    public void ShowSongButtons()
    {
        StopAllCoroutines();
        StartCoroutine(AnimateButtons(ShowAnimationName));
    }
    public void HideSongButtons()
    {
        StopAllCoroutines();
        StartCoroutine(AnimateButtons(hideAnimationName));
    }
    private IEnumerator AnimateButtons(string AnimationName)
    {
        foreach(Animator button in songButtons)
        {
            button.Play(AnimationName);
            yield return new WaitForSeconds(timeBetweenButtons);
        }
    }
    public void ShowCloseButton()
    {
        closeButton.Play(ShowAnimationName);
    }
    public void HideCloseButton()
    {
        closeButton.Play(hideAnimationName);
    }




}
