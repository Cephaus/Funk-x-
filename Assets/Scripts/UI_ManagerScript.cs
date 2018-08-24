using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_ManagerScript : MonoBehaviour {

    public void DisableBooleanAnimator(Animator anim)
    {
        anim.SetBool("IsDisplayed", false);
    }

    public void EnableBoolAnimator(Animator anim)
    {
        anim.SetBool("IsDisplayed", true);
    }

    public void NavigateTo(int scene)
    {
        Application.LoadLevel(scene);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
