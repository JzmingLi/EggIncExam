using System;
using UnityEngine;

public class Coop : MonoBehaviour
{
    ChickenManager chickenManager;

    private void Start()
    {
        chickenManager = ChickenManager.Instance;
    }

    public void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collided");
        if (other.gameObject.CompareTag("Chicken"))
        {
            Debug.Log("Chicken Collided");
            Destroy(other.gameObject);
            chickenManager.ChickenCount++;
        }
    }
}
