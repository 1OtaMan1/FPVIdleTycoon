using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI techText;
    public TextMeshProUGUI moneyText;

    void Update()
    {
        techText.text = "Tech: " + GameManager.Instance.technology.ToString("F0");
        moneyText.text = "Money: " + GameManager.Instance.money.ToString("F0");
    }
}