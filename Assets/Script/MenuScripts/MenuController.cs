using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MenuController : MonoBehaviour
{
    UIDocument menu;
    Button playButton;
    Button exitButton;

    public void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        VisualElement root = menu.rootVisualElement;

        playButton = root.Q<Button>("Play"); 
        exitButton = root.Q<Button>("Exit");

        playButton.RegisterCallback<ClickEvent>(loadSampleScene);
        exitButton.RegisterCallback<ClickEvent>(exitGame);
    }

    private void loadSampleScene(ClickEvent eve) 
    {
        SceneManager.LoadSceneAsync("SampleScene");
    }

    private void exitGame(ClickEvent eve)
    {
        Application.Quit();
    }
}
