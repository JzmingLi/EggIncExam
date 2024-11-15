using UnityEngine;

public class ChickenSpawner : MonoBehaviour
{
    [SerializeField] ChickenData _chickenData;
    
    public void OnSpawnChicken()
    {
        Instantiate(_chickenData.Prefab, transform.position, Quaternion.identity);
    }
}
