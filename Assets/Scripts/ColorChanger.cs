using DG.Tweening;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Renderer _renderer;
    [SerializeField] private Color _targetColor = Color.red;
    [SerializeField] private float _duration = 2f;
    [SerializeField] private LoopType _loopType = LoopType.Yoyo;

    private int _infiniteLoop = -1;

    private void Start()
    {
        _renderer.material.DOColor(_targetColor, _duration).SetLoops(_infiniteLoop, _loopType).SetEase(Ease.InOutSine);
    }
}