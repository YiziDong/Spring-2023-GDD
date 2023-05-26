using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_switch_gate : MonoBehaviour
{
    public Transform target;
    public Transform player;
    public bool SpawnersDead;
    [SerializeField] private Animator openDoor;
    [SerializeField] private string doorOpen = "openDoorAnimation";

    private void OnEnable()
    {
        float Tspeed = 5f;
        Vector3 targetPos = new Vector3(target.position.x, target.position.y, -10f);
        Vector3 originalPos = new Vector3(player.position.x, player.position.y, -10f);
        //pause the game
        Time.timeScale = 0;
        transform.position = Vector3.Slerp(transform.position, targetPos, Tspeed*Time.unscaledDeltaTime);
        //need to stay at the gate position for about 3s
        openDoor.Play(doorOpen, 0, (System.Math.Abs(targetPos.x - originalPos.x) + System.Math.Abs(targetPos.y - originalPos.y))/5);
        transform.position = Vector3.Slerp(transform.position, originalPos, Tspeed*Time.unscaledDeltaTime);
        //resume the game again
        Time.timeScale = 1;
    }

   
}
