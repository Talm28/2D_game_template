using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    Animator animator;


    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void EndScene(string nextScene)
    {
        Time.timeScale = 1f;
        animator.SetBool("IsEnd", true);
        StartCoroutine(LoadNewScene(nextScene));    
    }

    IEnumerator LoadNewScene(string sceneName)
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneName);
    }
}
