
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed = 5f;
    public float controlSpeed;


    void Update()
    {

        transform.position += Vector3.forward * Time.deltaTime * speed;
        if (Input.touchCount > 0)
        {
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            float NewPos = touchDeltaPosition.x * controlSpeed / Screen.width;
            transform.Translate(NewPos, 0, 0);

        }
    }
    public void AdjustSpeed(float newSpeed)
    {
        speed = newSpeed;
    }
}
