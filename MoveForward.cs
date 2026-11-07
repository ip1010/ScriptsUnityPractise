using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public int speed = 5;
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z +=  speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
