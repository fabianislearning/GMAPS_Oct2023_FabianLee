using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool IsCaptain = true;
    public Player OtherPlayer;

    //float Magnitude(Vector3 vector)
    //{
    //    // Your code here
    //}

    //Vector3 Normalise(Vector3 vector)
    //{
    //    // Your code here
    //}

    float Dot(Vector3 vectorB)
    {
        Vector3 vectorA = transform.forward;
        return (vectorA.x * vectorB.x) + (vectorA.y * vectorB.y) + (vectorA.z * vectorB.z);
    }

    float AngleToPlayer(Player player)
    {
        Vector3 vectorToOtherPlayer = OtherPlayer.transform.position - transform.position;
        vectorToOtherPlayer = vectorToOtherPlayer.normalized;

        float dot = Dot(vectorToOtherPlayer);
        float angle = Mathf.Acos(dot);
        angle = angle * Mathf.Rad2Deg;

        UnityEngine.Debug.Log($"Angle from {gameObject.name} to {OtherPlayer.gameObject.name} is {angle}");

        return angle;
    }

    void Update()
    {
        if (IsCaptain)
        {
            //Code to draw arrow from Player1 to Captain
            DebugExtension.DebugArrow(transform.position, OtherPlayer.transform.position - transform.position, Color.black);
            //Code to draw Captain's direction
            DebugExtension.DebugArrow(transform.position, transform.forward, Color.blue);

            //AngleToPlayer(OtherPlayer);
        }
    }
}
