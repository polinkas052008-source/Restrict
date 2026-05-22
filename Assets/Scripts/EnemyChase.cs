using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent myNavMeshAgent;
    [SerializeField] private Transform _goal;
    private Vector3 lastGoalPosition;
    //Start is called before the first frame update
    void Start()
    {
        myNavMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_goal.position != lastGoalPosition)
        {
            myNavMeshAgent.SetDestination(_goal.position);
            lastGoalPosition = _goal.position;
        }
    }
}
