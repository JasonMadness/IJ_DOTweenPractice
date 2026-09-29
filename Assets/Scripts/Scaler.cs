using DG.Tweening;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private Vector3 _targetScale;
    [SerializeField] private float _duration = 2f;
    [SerializeField] private LoopType _loopType = LoopType.Yoyo;

    private int _infiniteLoop = -1;

    private void Start()
    {
        transform.DOScale(_targetScale, _duration).SetLoops(_infiniteLoop, _loopType).SetEase(Ease.InOutSine);
    }
}
