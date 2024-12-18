using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMenuManager : MonoBehaviour
{
    public static UIMenuManager InstanceMenu;
    private void Awake(){
        InstanceMenu = this;
    }

    [SerializeField] Button goToLoginBtn;
    [SerializeField] Button goToSignupBtn;
    //[SerializeField] Button loginBtn;
    [SerializeField] Button goToLoginBtn1; //from signup page
    [SerializeField] Button goToSignupBtn1; //from login page
   

    


    public Canvas StartingPage;
    public Canvas LoginPage;
    public Canvas SignupPage;

   
   void Start(){
    goToLoginBtn.onClick.AddListener(() => OpenPage(LoginPage));
    goToLoginBtn1.onClick.AddListener(() => OpenPage(LoginPage));
    goToSignupBtn.onClick.AddListener(() => OpenPage(SignupPage));
    goToSignupBtn1.onClick.AddListener(() => OpenPage(SignupPage));
    //loginBtn.onClick.AddListener(ToMenuScene);//for testing purposes only

   }

   public void OpenPage(Canvas canvas){
    StartingPage.gameObject.SetActive(false);
    LoginPage.gameObject.SetActive(false);
    SignupPage.gameObject.SetActive(false);
    canvas.gameObject.SetActive(true);
   }

    void ToMenuScene(){
        SceneController.Instance.GoToMainMenu(); //
    }


}
