using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_menu : MonoBehaviour
{
    [SerializeField] private AudioClip soundMouseOver;
    [SerializeField] private AudioSource audioSource;

    [SerializeField] public string sceneName;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void MouseOver()
    {
        this.transform.localScale = new Vector2(1.1f, 1.1f);
        audioSource.PlayOneShot(soundMouseOver);
    }
    public void MouseExit()
    {
        this.transform.localScale = new Vector2(1f, 1f);
    }
    public void scene_Lv1()
    {
        sceneName = "Main1";
        SceneManager.LoadScene(sceneName);
    }
    public void scene_Menugame()
    {
        sceneName = "Menu";
        SceneManager.LoadScene(sceneName);
    }

    public void exit_game()
    {
        Application.Quit();
    }

}
