using System;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    [SerializeField] ChickenData chickenData;

    public Chicken(ChickenData data)
    {
        this.chickenData = data;
    }

    private void Update()
    {
        transform.LookAt(chickenData.TargetPosition);
        transform.position += (chickenData.TargetPosition - transform.position).normalized * (chickenData.Speed * Time.deltaTime);
    }
}
