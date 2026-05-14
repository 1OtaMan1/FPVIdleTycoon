using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text techText;
    public Text moneyText;

    void Update()
    {
        techText.text = "Tech: " + GameManager.Instance.technology.ToString("F0");
        moneyText.text = "Money: " + GameManager.Instance.money.ToString("F0");
    }
}
