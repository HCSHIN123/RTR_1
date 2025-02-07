using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 10f;

    private void FixedUpdate()
    {
        transform.position += Vector3.right * moveSpeed * Time.deltaTime;
    }
}
