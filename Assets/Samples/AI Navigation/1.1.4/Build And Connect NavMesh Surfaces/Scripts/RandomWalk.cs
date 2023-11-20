using UnityEngine;
using UnityEngine.AI;

namespace Unity.AI.Navigation.Samples
{
  /// <summary>
  /// Walk to a random position and repeat
  /// </summary>
  [RequireComponent(typeof(NavMeshAgent))]
  public class RandomWalk : MonoBehaviour
  {
    public float m_Range = 25.0f;
    public Vector3 target = Vector3.zero;
    NavMeshAgent m_Agent;
  
    void Start()
    {
      m_Agent = GetComponent<NavMeshAgent>();
    }
  
    void Update()
    {
      if (m_Agent.pathPending || !m_Agent.isOnNavMesh || m_Agent.remainingDistance > 0.1f)
        return;

      Vector3 destination = Random.insideUnitSphere;
      Debug.Log(destination); // print destination

      target = m_Range * destination;
      
      Debug.Log(target); // print destination
      m_Agent.destination = target;
    }
  }
}