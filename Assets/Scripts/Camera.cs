using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    public Player player;
    public Vector3 PlatformToCameraOffset;
    public float Speed;


    // Update is called once per frame
    void Update()
    {
        if (player.CurrentPlatform == null) return;

        Vector3 targetPosition = player.CurrentPlatform.transform.position + PlatformToCameraOffset;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition,Speed*Time.deltaTime);
    }

}