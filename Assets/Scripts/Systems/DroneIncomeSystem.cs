using UnityEngine;

public class DroneIncomeSystem : MonoBehaviour
{
    public DroneManager droneManager;

    void Update()
    {
        float income = droneManager.drones * droneManager.incomePerDrone * Time.deltaTime;
        GameManager.Instance.money += income;
    }
}