using System;
using UnityEngine;

public class ChickenManager : MonoBehaviour
{
    private static ChickenManager _instance;

    public static ChickenManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindFirstObjectByType<ChickenManager>();
                if (_instance == null)
                {
                    GameObject obj = new GameObject();
                    obj.name = "ChickenManager";
                    _instance = obj.AddComponent<ChickenManager>();
                }
            }
            return _instance;
        }
    }
    
    public int ChickenCount;
    public float Money;
    public float MoneyPerSecond;

    private void Update()
    {
        MoneyPerSecond = ChickenCount;
        Money += ChickenCount * Time.deltaTime;
    }
}
