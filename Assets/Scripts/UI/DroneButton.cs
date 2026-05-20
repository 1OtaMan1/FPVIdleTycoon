using UnityEngine;

public class DroneButton : MonoBehaviour
{
    public int droneId;
    public float cost;
    [SerializeField] private DroneManager droneManager;

    public void BuyDrone()
    {
        if (GameManager.Instance.technology >= cost)
        {
            GameManager.Instance.technology -= cost;
            droneManager.AddDrone();
        }
    }
}