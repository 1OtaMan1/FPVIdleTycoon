using UnityEngine;

public class WorkerManager : MonoBehaviour
{
    public int workers = 0;
    public float techPerWorker = 2f;

    public void HireWorker()
    {
        float cost = 50 + workers * 25;

        if (GameManager.Instance.money >= cost)
        {
            GameManager.Instance.money -= cost;
            workers++;
        }
    }

    public float GetTechPerSecond()
    {
        return workers * techPerWorker;
    }

    public float GetWorkerCost()
    {
        return 50 + workers * 25;
    }
}
