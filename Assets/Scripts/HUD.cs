using TMPro;
using UnityEngine;

public class HUD : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI chickenCounter;
    [SerializeField] private TextMeshProUGUI moneyCounter;
    [SerializeField] private TextMeshProUGUI moneyPerSecond;
    ChickenManager chickenManager;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        chickenManager = ChickenManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        chickenCounter.text = "Chickens: " + chickenManager.ChickenCount;
        moneyCounter.text = "$" + Mathf.Round(chickenManager.Money * 100f) / 100f;
        moneyPerSecond.text = "$" + chickenManager.MoneyPerSecond + "/SEC";
    }
}
