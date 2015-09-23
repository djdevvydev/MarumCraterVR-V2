using UnityEngine;
using UnityEditor;

public class EditorPathPointSetup : Editor
{
    [MenuItem("PathPointSetup/SetPathPointHeight")]
    static void SetPathPointHeight()
    {
        Debug.Log("Adjust Path Points!");
        GameObject pathpointContainer = GameObject.Find("VRPathContainer");
        for(int i = 0; i < pathpointContainer.transform.childCount; i++)
        {
            RaycastHit hit;
            Vector3 rayDirection = pathpointContainer.transform.GetChild(i).TransformDirection(Vector3.down);
            Vector3 rayStart = pathpointContainer.transform.GetChild(i).position;
            if(Physics.Raycast(rayStart, rayDirection, out hit))
            {
                float distToGround = hit.distance;
                if(distToGround > 2.0F)
                {
                    pathpointContainer.transform.GetChild(i).position = new Vector3(pathpointContainer.transform.GetChild(i).position.x, pathpointContainer.transform.GetChild(i).position.y - (distToGround - 2.0F),
                        pathpointContainer.transform.GetChild(i).position.z);
                }
            }
        }
    }
}