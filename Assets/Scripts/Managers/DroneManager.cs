using UnityEngine;


public class DroneManager : MonoBehaviour
{
    public int drones = 0;
    public float baseCost = 20f;
    public float baseIncome = 10f;

    public void CreateDrone()
    {
        float cost = baseCost * Mathf.Pow(1.15f, drones);

        if (GameManager.Instance.technology >= cost)
        {
            GameManager.Instance.technology -= cost;
            drones++;

            float income = baseIncome * drones;
            GameManager.Instance.money += income;
        }
    }
}
