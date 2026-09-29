using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _targetPosition;
    [SerializeField] private float _duration = 5f;
    [SerializeField] private LoopType _loopType;

    private int _infiniteLoop = -1;

    private void Start()
    {
        transform.DOMove(_targetPosition, _duration).SetLoops(_infiniteLoop, _loopType);
    }
}
