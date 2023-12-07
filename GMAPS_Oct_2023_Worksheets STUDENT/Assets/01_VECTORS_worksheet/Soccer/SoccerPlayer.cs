using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SoccerPlayer : MonoBehaviour
{
    public bool IsCaptain = false;
    public SoccerPlayer[] OtherPlayers;
    public float rotationSpeed = 1f;

    float angle = 0f;

    private void Start()
    {
        OtherPlayers = FindObjectsOfType<SoccerPlayer>().Where(t => t != this).ToArray();

        /* OtherPlayers = FindObjectsOfType<SoccerPlayer>();
        SoccerPlayer[] temp = new SoccerPlayer[OtherPlayers.Length - 1];
        int i = 0;
        foreach (SoccerPlayer p in OtherPlayers)
        {
            if (p != this)
            {
                temp[i] = p;
                i++;
            }
        }
        OtherPlayers = temp;
        Debug.Log(OtherPlayers.Length);*/
    }

    float Magnitude(Vector3 vector)
    {
        Vector3 vectorA = transform.forward;
        return Mathf.Sqrt(vectorA.x * vectorA.x + vectorA.y * vectorA.y);
    }

    Vector3 Normalise(Vector3 vector)
    {
        float mag = Magnitude(vector);
        vector.x /= mag;
        vector.y /= mag;

        return vector;
    }

    float Dot(Vector3 vectorB)
    {
        Vector3 vectorA = transform.forward;
        return (vectorA.x * vectorB.x) + (vectorA.y * vectorB.y) + (vectorA.z * vectorB.z);
    }

    //SoccerPlayer FindClosestPlayerDot()
    //{
    //    SoccerPlayer closest = null;
    //    float minAngle = 180f;

    //    for (int i = 0; i < OtherPlayers.Length; i++)
    //    {
    //        Vector3 toPlayer = OtherPlayers[i].transform.position;
    //        closest = Normalise(toPlayer);

    //        float dot = Dot(toPlayer);
    //        float angle = Mathf.Acos(dot);
    //        angle = angle * Mathf.Rad2Deg;

    //        if (angle < minAngle)
    //        {
    //            minAngle = angle;
    //            closest = transform.position;
    //        }
    //    }

    //    return closest;
    //}

    void DrawVectors()
    {
        foreach (SoccerPlayer other in OtherPlayers)
        {
            if (OtherPlayers.Length < other.OtherPlayers.Length)
            {
                DebugExtension.DebugArrow(transform.position, other.transform.position - transform.position, Color.black);
            }
        }
    }

    void Update()
    {
        DebugExtension.DebugArrow(transform.position, transform.forward, Color.red);

        if (IsCaptain)
        {
            angle += Input.GetAxis("Horizontal") * rotationSpeed;
            transform.localRotation = Quaternion.AngleAxis(angle, Vector3.up);
            Debug.DrawRay(transform.position, transform.forward * 10f, Color.red);
        }

        DrawVectors();
    }
}


