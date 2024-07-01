using UnityEngine;
using UnityEngine.UIElements;

public class DashboardBehaviour : MonoBehaviour
{
    public UIManager uiManager;
    
    private VisualElement _dashboardPageView;
    private Button _logoutButton;
    
    private void Awake()
    {
        _dashboardPageView = GetComponent<UIDocument>().rootVisualElement;

        _logoutButton = _dashboardPageView.Q<VisualElement>("LogoutButton").Q<Button>("Button");
        _logoutButton.clicked += OnHandleLogoutButtonClick;

    }

    private void OnHandleLogoutButtonClick()
    {
        uiManager.ShowLoginView();
    }
}
