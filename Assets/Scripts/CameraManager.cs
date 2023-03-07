using UnityEngine;

public class CameraManager : MonoBehaviour
{
    #region Variables

    [SerializeField] private Transform target;
    [SerializeField] private float smoothTime;
    
    private Vector3 _offset;
    private Vector3 _currentVelocity = Vector3.zero;

    #endregion

    private void Awake() => _offset = transform.position - target.position;

    private void LateUpdate()
    {
        var targetPosition = target.position + _offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref _currentVelocity, smoothTime);
    }
}
