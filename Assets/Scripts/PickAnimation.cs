using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickAnimation : MonoBehaviour
{
    Animator danceAnimator;
    void Start()
    {
        danceAnimator = FindObjectOfType<Animator>();           
    }

    public void HouseDance(){
        danceAnimator.SetTrigger("House");
    }

    public void MacarenaDance(){
        danceAnimator.SetTrigger("Macarena");
    }

    public void HipHopDance(){
        danceAnimator.SetTrigger("HipHop");
    }

    public void LoadNextScene(){
        SceneManager.LoadScene(1);
    }
}
