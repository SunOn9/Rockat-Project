using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] private DoorSetActive door;
    [SerializeField] private DoorSetUnactive door1;
    [SerializeField] private DoorSetUnactive door2;

    public List<SpriteRenderer> runes;
    public float lerpSpeed = 1;

    private Color curColor;
    private Color targetColor;

    private void OnTriggerEnter2D(Collider2D other)
    {
        targetColor = new Color(1, 1, 1, 1);
        door.OpenDoor();
        door1.OpenDoor();
        door2.OpenDoor();
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        targetColor = new Color(1, 1, 1, 0);
        door.CloseDoor();
        door1.CloseDoor();
        door2.CloseDoor();
    }

    private void Update()
    {
        curColor = Color.Lerp(curColor, targetColor, lerpSpeed * Time.deltaTime);

        foreach (var r in runes)
        {
            r.color = curColor;
        }
    }
}
