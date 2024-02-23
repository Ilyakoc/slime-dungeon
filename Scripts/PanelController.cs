using UnityEngine;

public class PanelController : MonoBehaviour
{
    [SerializeField] GameObject shopPanel;
    [SerializeField] GameObject settingsPanel;
    [SerializeField] GameObject skillsPanel;
    [SerializeField] GameObject playerPanel;
    [SerializeField] GameObject backpackPanel;
    [SerializeField] GameObject encyclopediaPanel;
    [SerializeField] GameObject mainPanel;

    bool openPanel;

    public void OpenShop()
    {
        if(!openPanel || shopPanel.activeSelf)
        {
            mainPanel.SetActive(!mainPanel.activeSelf);
            shopPanel.SetActive(!shopPanel.activeSelf);
            openPanel = shopPanel.activeSelf;
        }
    }

    public void OpenSettings()
    {
        if(!openPanel || settingsPanel.activeSelf)
        {
            mainPanel.SetActive(!mainPanel.activeSelf);
            settingsPanel.SetActive(!settingsPanel.activeSelf);
            openPanel = settingsPanel.activeSelf;
        }
    }

    public void OpenSkills()
    {
        if(!openPanel || skillsPanel.activeSelf)
        {
            mainPanel.SetActive(!mainPanel.activeSelf);
            skillsPanel.SetActive(!skillsPanel.activeSelf);
            openPanel = skillsPanel.activeSelf;
        }
    }

    public void OpenPlayer()
    {
        if(!openPanel || playerPanel.activeSelf)
        {
            mainPanel.SetActive(!mainPanel.activeSelf);
            playerPanel.SetActive(!playerPanel.activeSelf);
            openPanel = playerPanel.activeSelf;
        }
    }

    public void OpenBackpack()
    {
        if(!openPanel || backpackPanel.activeSelf)
        {
            mainPanel.SetActive(!mainPanel.activeSelf);
            backpackPanel.SetActive(!backpackPanel.activeSelf);
            openPanel = backpackPanel.activeSelf;
        }
    }

    public void OpenEncyclopedia()
    {
        if(!openPanel || encyclopediaPanel.activeSelf)
        {
            mainPanel.SetActive(!mainPanel.activeSelf);
            encyclopediaPanel.SetActive(!encyclopediaPanel.activeSelf);
            openPanel = encyclopediaPanel.activeSelf;
        }
    }

    public void OpenMain()
    {
            playerPanel.SetActive(false);
            skillsPanel.SetActive(false);
            shopPanel.SetActive(false);
            backpackPanel.SetActive(false);
            settingsPanel.SetActive(false);
            encyclopediaPanel.SetActive(false);
            mainPanel.SetActive(!mainPanel.activeSelf);
            openPanel = false;
    }
}
