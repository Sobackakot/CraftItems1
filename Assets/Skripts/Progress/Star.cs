using UnityEngine;
using UnityEngine.UI;

public class Star : MonoBehaviour
{
    [SerializeField] private int _level;
    [SerializeField] private Image _icon;
    [SerializeField] private ParticleSystem _partical;

    public int Level => _level;

    public void SetStar(int level, Sprite sprite)
    {
        _level = level;
        _icon.sprite = sprite;
        _partical.Stop();
        _partical.Play();
    }
}

