using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_switch_gate : MonoBehaviour
{
    public Transform target;
    public Transform player;
    public bool SpawnersDead;


    private void OnEnable() {
        float Tspeed = System.Math.Min(System.Math.Abs(target.position.x - player.position.x) + System.Math.Abs(target.position.y - player.position.y), 5f);
        Vector3 targetPos = new Vector3(target.position.x, target.position.y, -10f);
        Vector3 originalPos = new Vector3(player.position.x, player.position.y, -10f);
        transform.position = Vector3.Slerp(transform.position, targetPos, Tspeed*Time.deltaTime);
        yield return new WaitForSeconds(3);
        transform.position = Vector3.Slerp(transform.position, originalPos, Tspeed*Time.deltaTime);
    }
    
}
