// MoveTo.cs
using UnityEngine;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour {

   public Transform goal;

    //Al incrementar la velocidad el comportamiento se vuelve mas erratico, solo mejora en las rectas
    // public float speed = 15f;

   void Start () {
      NavMeshAgent agent = GetComponent<NavMeshAgent>();
      agent.destination = goal.position;

     // agent.speed = speed; // Incrementa la velocidad del agente
   }
}
