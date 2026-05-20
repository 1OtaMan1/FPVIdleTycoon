using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public Button createDroneButton;
    public Button hireWorkerButton;
    public TextMeshProUGUI techText;
    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI workersText;
    public TextMeshProUGUI dronesText;
    public TextMeshProUGUI droneButtonText;
    public TextMeshProUGUI workerButtonText;
    public WorkerManager workerManager;
    public DroneManager droneManager;

    void Update()
    {
        techText.text = "Tech: " + GameManager.Instance.technology.ToString("F0");
        moneyText.text = "Money: " + GameManager.Instance.money.ToString("F0");

        workersText.text = "Workers: " + workerManager.workers;
        dronesText.text = "Drones: " + droneManager.drones;

        droneButtonText.text = "Create Drone";
        workerButtonText.text = "Hire Worker (" + workerManager.GetWorkerCost().ToString("F0") + ")";

        hireWorkerButton.interactable = GameManager.Instance.money >= workerManager.GetWorkerCost();
    }
}