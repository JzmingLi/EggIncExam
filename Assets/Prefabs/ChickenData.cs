using UnityEngine;

[CreateAssetMenu(fileName = "ChickenData", menuName = "Scriptable Objects/ChickenData")]
public class ChickenData : ScriptableObject
{
    public GameObject Prefab;
    public Vector3 TargetPosition;
    public float Speed;
}
