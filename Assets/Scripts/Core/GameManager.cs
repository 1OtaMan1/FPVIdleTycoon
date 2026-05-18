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

    void Start()
    {
        GetComponent<SaveSystem>().Load();
    }

    void OnApplicationQuit()
    {
        GetComponent<SaveSystem>().Save();
    }

    void OnApplicationPause(bool pause)
    {
        if (pause)
        {
            GetComponent<SaveSystem>().Save();
        }
    }
}