using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField]
    private Door Door;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<CapsuleCollider>(out CapsuleCollider capsuleCollider))
        {
            if (!Door.IsOpen)
            {
                Door.Open(other.transform.position);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent<CapsuleCollider>(out CapsuleCollider capsuleCollider))
        {
            if (Door.IsOpen)
            {
                Door.Close();
            }
        }
    }
}