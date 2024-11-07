using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenuManager : MonoBehaviour
{
    [SerializeField] Button goBackBtn;
    // Start is called before the first frame update
    void Start()
    {
        goBackBtn.onClick.AddListener(ToStartingScene);
    }

    // private void GoTo(){
    //     SceneController.Instance.GoToScene(SceneController.Scene.LoginScene);
    // }

    private void ToStartingScene(){
        SceneController.Instance.GoToStartingScene();
    }

  
}
