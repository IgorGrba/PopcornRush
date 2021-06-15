using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField] Transform Player;
    [SerializeField] Transform EndLine;
    [SerializeField] Slider slider;

    float maxDistance;


    void Start()
    {
        maxDistance = getDistance();
    }


    void Update()
    {
        if (Player.position.y <=maxDistance && Player.position.y<=EndLine.position.y)
        {
            float distance = 1 - (getDistance() / maxDistance);
            setProgress (distance);
        }
    }

    float getDistance()
    {
        return Vector3.Distance (Player.position, EndLine.position);
    }

    void setProgress(float p)
    {
        slider.value = p;
    }
}
