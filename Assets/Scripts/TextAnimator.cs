using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextAnimator : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private string _firstText;
    [SerializeField] private string _secondText;
    [SerializeField] private string _thirdText;
    [SerializeField] private float _duration = 2f;
    [SerializeField] private LoopType _loopType = LoopType.Restart;

    private Sequence _sequence;
    private float _pauseDuration = 1f;
    private int _infiniteLoop = -1;

    private void Start()
    {
        _text.text = string.Empty;
        _sequence = DOTween.Sequence();
        PlaySequence();
    }

    private void PlaySequence()
    {
        _sequence.Append(_text.DOText(_firstText, _duration));

        _sequence.AppendInterval(_pauseDuration);
        _sequence.Append(_text.DOText("\n" + _secondText, _duration).SetRelative());

        _sequence.AppendInterval(_pauseDuration);
        _sequence.Append(_text.DOText(_thirdText, _duration, scrambleMode: ScrambleMode.All));

        _sequence.SetLoops(_infiniteLoop, _loopType);
        _sequence.AppendInterval(_pauseDuration);
    }
}