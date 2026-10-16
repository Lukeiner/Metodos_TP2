using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NewMonoBehaviourScript : MonoBehaviour
{
    private NavMeshAgent agent;
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Start()
    {
        SetDestinationToEndTile();
    }

    private void SetDestinationToEndTile()
    {
        GameObject endTile = GameObject.FindWithTag("Finish");

        if (endTile == null)
        {
            endTile = GameObject.Find("Finish");
        }

        if (endTile != null)
        {
            agent.SetDestination(endTile.transform.position);
        }
        else
        {
            Debug.LogWarning($"[{gameObject.name}] No se encontró el objeto End_Tile en la escena.");
        }
    }


}
