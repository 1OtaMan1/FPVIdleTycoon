using UnityEngine;
using System;

public class SaveSystem : MonoBehaviour
{
    private const string SAVE_KEY = "SAVE_DATA";

    [Serializable]
    public class SaveData
    {
        public float money;
        public float technology;
        public int workers;
        public int drones;
        public long lastSaveTime;
    }

    public WorkerManager workerManager;
    public DroneManager droneManager;

    public void Save()
    {
        SaveData data = new SaveData();

        data.money = GameManager.Instance.money;
        data.technology = GameManager.Instance.technology;
        data.workers = workerManager.workers;
        data.drones = droneManager.drones;
        data.lastSaveTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

        string json = JsonUtility.ToJson(data);
        PlayerPrefs.SetString(SAVE_KEY, json);
        PlayerPrefs.Save();

        Debug.Log("Game Saved");
    }

    public void Load()
    {
        if (!PlayerPrefs.HasKey(SAVE_KEY))
            return;

        string json = PlayerPrefs.GetString(SAVE_KEY);
        SaveData data = JsonUtility.FromJson<SaveData>(json);

        GameManager.Instance.money = data.money;
        GameManager.Instance.technology = data.technology;
        workerManager.workers = data.workers;
        droneManager.drones = data.drones;

        ApplyOfflineProgress(data.lastSaveTime);

        Debug.Log("Game Loaded");
    }

    void ApplyOfflineProgress(long lastSaveTime)
    {
        long currentTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
        long secondsOffline = currentTime - lastSaveTime;

        float techPerSecond = workerManager.workers * workerManager.techPerWorker;
        float moneyPerSecond = droneManager.drones * droneManager.incomePerDrone;

        GameManager.Instance.technology += techPerSecond * secondsOffline;
        GameManager.Instance.money += moneyPerSecond * secondsOffline;

        Debug.Log("Offline seconds: " + secondsOffline);
    }
}