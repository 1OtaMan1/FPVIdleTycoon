using UnityEngine;

public class EconomyManager : MonoBehaviour
{
    public float rent = 5f;
    public float salaryPerWorker = 2f;

    public WorkerManager workerManager;

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 5f)
        {
            float totalCost = rent + workerManager.workers * salaryPerWorker;
            GameManager.Instance.money -= totalCost;

            timer = 0f;
        }
    }
}
