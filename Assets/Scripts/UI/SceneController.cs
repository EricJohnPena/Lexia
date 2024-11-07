using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{ 
    public static SceneController Instance;
    private void Awake(){
        Instance = this;
    }
    public enum Scene{
        LoginScene,
        MenuScene
    }
    
    public void GoToScene(Scene sceneName)
    {
        SceneManager.LoadScene(sceneName.ToString());
      
    }
    public void GoToStartingScene(){
        SceneManager.LoadScene(Scene.LoginScene.ToString());
    }

    public void GoToMainMenu(){
        SceneManager.LoadScene(Scene.MenuScene.ToString());
        
    }

    // public void CreateNewGame(){
    //     SceneManager.LoadScene(Scene.GameScene.ToString());
        
    // }
}