using System.Collections.Generic;
using UnityEngine;

public class FitCards : MonoBehaviour
{
    public List<GameObject> items = new List<GameObject>(6);
    private int rotationAngle;

    private void Start()
    {
        rotationAngle = 16;

        for (int i = 0; i < items.Count; i++)
        {
            rotationAngle = rotationAngle - 7;
            items[i].transform.localRotation = Quaternion.Euler(0, 0, rotationAngle);
        }

        var leftPoint = items[0].transform.position;
        var rightPoint = items[1].transform.position;
        var delta = (rightPoint - leftPoint).magnitude;
        var howMany = items.Count;
        var howManyGapsBetweenItems = howMany - 3;
        var theHighestIndex = howMany;
        var gapFromOneItemToTheNextOne = delta / howManyGapsBetweenItems;

        for (int i = 0; i < theHighestIndex; i++)
        {
            items[i].transform.position = leftPoint;
            items[i].transform.position += new Vector3((i * gapFromOneItemToTheNextOne), items[i].transform.position.y + 140.0f, items[i].transform.position.z);
        }
    }
}