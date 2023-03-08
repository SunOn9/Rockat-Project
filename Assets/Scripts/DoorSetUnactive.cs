using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSetUnactive : MonoBehaviour
{
    public void Start()
    {
        gameObject.SetActive(false);
    }
    public void OpenDoor()
    {
        gameObject.SetActive(true);
    }
    public void CloseDoor()
    {
        gameObject.SetActive(false);
    }
}
