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

    private Sequence _sequence;

    private void Start()
    {
        _text.text = string.Empty;
        PlaySequence();
    }

    private void PlaySequence()
    {
        _sequence?.Kill();
        _sequence = DOTween.Sequence();

        // 1. Добавление (печатающий эффект)
        _sequence.Append(_text.DOText(_firstText, _duration));

        // 2. Замена (мигание на новый текст)
        _sequence.AppendInterval(0.5f);
        _sequence.Append(_text.DOText(_secondText, _duration * 0.5f));

        // 3. Эффект замены с перебором (Scramble)
        _sequence.AppendInterval(0.5f);
        _sequence.Append(_text.DOText(
            _thirdText,
            _duration,
            scrambleMode: ScrambleMode.All));

        _sequence.SetLoops(-1, LoopType.Restart);
    }
}