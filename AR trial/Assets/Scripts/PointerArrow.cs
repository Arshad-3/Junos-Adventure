using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerArrow : MonoBehaviour
{
    [SerializeField] private GameObject waypoint;

    private void FixedUpdate()
    {
        Vector3 distance = waypoint.transform.position - transform.position;
        Vector3 newDistance = new Vector3(waypoint.transform.position.x, distance.y, waypoint.transform.position.z);
        Quaternion direction = Quaternion.LookRotation(distance);
        transform.rotation = Quaternion.Lerp(transform.rotation,direction,8f*Time.deltaTime);
    }
}
