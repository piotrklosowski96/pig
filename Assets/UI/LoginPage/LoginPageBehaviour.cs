using UnityEngine;
using UnityEngine.UIElements;

public class LoginPageBehaviour : MonoBehaviour
{
    public UIManager uiManager;
    
    private VisualElement _loginPageView;
    private Button _loginButton;
    
    private void Awake()
    {
        _loginPageView = GetComponent<UIDocument>().rootVisualElement;
        
        _loginButton = _loginPageView.Q<Button>("LoginButton");
        _loginButton.clicked += OnHandleLoginButtonClick;
    }

    private void OnHandleLoginButtonClick()
    {
        uiManager.ShowDashboardView();
    }
}
