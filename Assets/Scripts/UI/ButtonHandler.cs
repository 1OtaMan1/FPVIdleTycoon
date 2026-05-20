using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public DroneManager droneManager;
    public WorkerManager workerManager;

    public void OnCreateDrone()
    {
        droneManager.AddDrone();
    }

    public void OnHireWorker()
    {
        workerManager.HireWorker();
    }
}
