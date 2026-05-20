using UnityEngine;

public class DroneMenuUI : MonoBehaviour
{
    public GameObject droneMenu;

    public void OpenMenu()
    {
        droneMenu.SetActive(true);
    }

    public void CloseMenu()
    {
        droneMenu.SetActive(false);
    }
}