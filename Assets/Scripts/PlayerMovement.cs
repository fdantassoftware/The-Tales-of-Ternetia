using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    private NavMeshAgent navAgent;
    private Animator animator;
  
    private void Awake() {
        navAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetMouseButton(0)) {
            MoveToCursor();
        }
        UpdateAnimation();
    }

    private void MoveToCursor() {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        // If the ray hits something, grab the info of the point and move the player to it
        if (Physics.Raycast(ray, out RaycastHit hit)) {
            navAgent.destination = hit.point;
        }
    }

    private void UpdateAnimation() {
        Vector3 velocity = navAgent.velocity;
        Vector3 localVelocity = transform.InverseTransformDirection(velocity);
        float speed = localVelocity.z;
        animator.SetFloat("forwardSpeed", speed);
    }
}
