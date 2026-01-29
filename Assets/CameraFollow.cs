using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;  // 따라갈 플레이어
    public float smoothSpeed = 0.125f;  // 부드러운 따라가기 속도
    public Vector3 offset = new Vector3(0, 0, -10);  // 카메라와 플레이어 거리
    
    void LateUpdate()
    {
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}