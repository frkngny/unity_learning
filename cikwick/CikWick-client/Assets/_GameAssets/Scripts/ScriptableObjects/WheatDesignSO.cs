using UnityEngine;

[CreateAssetMenu(fileName = "WheatDesignSO", menuName = "ScriptableObjects/WheatDesignSO", order = 0)]
public class WheatDesignSO : ScriptableObject
{
    [SerializeField] private float increaseDecreaseMultiplier;
    [SerializeField] private float resetBootDuration;

    public float IncreaseDecreaseMultiplier => increaseDecreaseMultiplier;
    public float ResetBoostDuration => resetBootDuration;
    
}

