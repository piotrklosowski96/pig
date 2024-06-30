using UnityEngine;
using UnityEngine.UIElements;

public class UIManager : MonoBehaviour
{
    public UIDocument loginView;
    public UIDocument dashboardView;

    private void Awake()
    {
        loginView.rootVisualElement.visible = true;
        dashboardView.rootVisualElement.visible = false;
    }
    
    public void ShowDashboardView()
    {
        loginView.rootVisualElement.visible = false;
        dashboardView.rootVisualElement.visible = true;
    }
}
