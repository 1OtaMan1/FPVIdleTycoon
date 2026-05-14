using UnityEngine;

public class TechnologySystem : MonoBehaviour
{
    public float techPerTick = 10f;
    public float tickTime = 5f;

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= tickTime)
        {
            GameManager.Instance.technology += techPerTick;
            timer = 0f;
        }
    }
}
