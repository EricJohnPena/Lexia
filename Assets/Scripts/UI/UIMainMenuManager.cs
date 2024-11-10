using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class UIMainMenuManager : MonoBehaviour
{
    public static UIMainMenuManager InstanceMainMenu;
    private void Awake(){
        InstanceMainMenu = this;

    }
     [SerializeField] Button goBackBtn;
     //[SerializeField] Button classBtn;
     [SerializeField] Button backBtn;
      public Text displayText;
     

    public Canvas mainPage;
    public Canvas selectClassroomPage;

    public Canvas classroomPage;
    public Canvas createClassModal;



    // Start is called before the first frame update
    void Start()
    {
        goBackBtn.onClick.AddListener(ToStartingScene);
        backBtn.onClick.AddListener(() => OpenPage(selectClassroomPage));
   string userName = PlayerPrefs.GetString("UserName", "Unknown");
    displayText.text = "Hi " + userName + ", let's";
        
    }

    // private void GoTo(){
    //     SceneController.Instance.GoToScene(SceneController.Scene.LoginScene);
    // }

    private void ToStartingScene(){
        SceneController.Instance.GoToStartingScene();
    }

    public void OpenPage(Canvas canvas){
    mainPage.gameObject.SetActive(false);
    selectClassroomPage.gameObject.SetActive(false);
    classroomPage.gameObject.SetActive(false);
    canvas.gameObject.SetActive(true);
   }
   public void OpenClassroom(){
    mainPage.gameObject.SetActive(false);
    selectClassroomPage.gameObject.SetActive(false);
    classroomPage.gameObject.SetActive(true);
   }

   public void OpenMainPage(){
    selectClassroomPage.gameObject.SetActive(false);
    classroomPage.gameObject.SetActive(false);
    mainPage.gameObject.SetActive(true);
    
   }

   public void OpenModal(){
    createClassModal.gameObject.SetActive(true);
   }
   public void CloseModal(){
    createClassModal.gameObject.SetActive(false);
   }

  
   

  
}
