using UnityEngine;
using UnityEngine.UIElements;

public class UIManager : MonoBehaviour
{
    public UIDocument loginView;
    public UIDocument dashboardView;

    private LoginPageBehaviour _loginPageBehaviour;
    private DashboardBehaviour _dashboardBehaviour;
    
    private void Awake()
    {
        loginView.rootVisualElement.visible = true;
        dashboardView.rootVisualElement.visible = false;
    }

    public void SetLoginBehaviour(LoginPageBehaviour lb)
    {
        _loginPageBehaviour = lb;
    }
    
    public void SetDashboardBehaviour(DashboardBehaviour db)
    {
        _dashboardBehaviour = db;
    }
    
    public void ShowLoginView()
    {
        loginView.rootVisualElement.visible = true;
        loginView.rootVisualElement.style.display = DisplayStyle.Flex;

        dashboardView.rootVisualElement.visible = false;
        dashboardView.rootVisualElement.style.display = DisplayStyle.None;
    }
    
    public void ShowDashboardView()
    {
        loginView.rootVisualElement.visible = false;
        loginView.rootVisualElement.style.display = DisplayStyle.None;

        dashboardView.rootVisualElement.visible = true;
        dashboardView.rootVisualElement.style.display = DisplayStyle.Flex;
        
        _dashboardBehaviour.ShowActivityPopup();
    }
}
