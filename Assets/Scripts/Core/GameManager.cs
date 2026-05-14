using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public float technology = 0;
    public float money = 0;

    private void Awake()
    {
        Instance = this;
    }
}