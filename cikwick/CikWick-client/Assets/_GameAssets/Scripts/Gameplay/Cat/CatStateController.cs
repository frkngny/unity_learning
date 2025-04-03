using UnityEngine;

public class CatStateController : MonoBehaviour
{
    [SerializeField] private CatState currentState = CatState.Idle;
    public CatState CurrentState => currentState; // Read-only property to access the current state

    private void Start()
    {
        ChangeState(CatState.Idle); // Initialize the state to Idle at the start
    }

    public void ChangeState(CatState newState)
    {
        if(currentState == newState) return; // No state change if the same state is assigned
        
        currentState = newState;
    }
}
