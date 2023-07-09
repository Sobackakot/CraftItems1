using UnityEngine;
using UnityEngine.UI;

public class Star : MonoBehaviour
{
    [SerializeField] private Image _icon;
    [SerializeField] private ParticleSystem _partical;

    public void SetStar(Sprite sprite)
    {
        _icon.sprite = sprite;
        _partical.Stop();
        _partical.Play();
    }
}
