using UnityEngine;

public class PassiveIncomeSystem : MonoBehaviour
{
    public WorkerManager workerManager;

    void Update()
    {
        float tech = workerManager.GetTechPerSecond() * Time.deltaTime;
        GameManager.Instance.technology += tech;
    }
}
