using UnityEngine;
using UnityEngine.UIElements;

public class DashboardBehaviour : MonoBehaviour
{
    public UIManager uiManager;
    
    private VisualElement _dashboardPageView;
    private Button _logoutButton;
    
    private VisualElement _activityPopup;
    private Button _refreshSessionButton;
    
    private void Awake()
    {
        uiManager.SetDashboardBehaviour(this);
        _dashboardPageView = GetComponent<UIDocument>().rootVisualElement;
        
        _activityPopup = _dashboardPageView.Q<VisualElement>("ActivityPopup");
        _refreshSessionButton = _activityPopup.Q<Button>();
        _refreshSessionButton.clicked += OnRefreshedSessionButton;
        HideActivityPopup();
        
        _logoutButton = _dashboardPageView.Q<VisualElement>("LogoutButton").Q<Button>("Button");
        _logoutButton.clicked += OnHandleLogoutButtonClick;
    }
    
    private void OnHandleLogoutButtonClick()
    {
        uiManager.ShowLoginView();
    }

    private void OnRefreshedSessionButton()
    {
        HideActivityPopup();
    }

    public void ShowActivityPopup()
    {
        _activityPopup.style.display = DisplayStyle.Flex;
        _activityPopup.visible = true;
        _activityPopup.SetEnabled(true);
    }

    public void HideActivityPopup()
    {
        _activityPopup.style.display = DisplayStyle.None;
        _activityPopup.visible = false;
        _activityPopup.SetEnabled(false);
    }
}
