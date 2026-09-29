using DG.Tweening;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _targetRotation;
    [SerializeField] private float _duration = 5f;
    [SerializeField] private LoopType _loopType = LoopType.Restart;

    private int _infiniteLoop = -1;

    private void Start()
    {
        transform.DORotate(_targetRotation, _duration).SetLoops(_infiniteLoop, _loopType).SetEase(Ease.Linear);
    }
}
