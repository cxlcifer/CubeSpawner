using UnityEngine;

public class Recoloring : MonoBehaviour
{
    private Renderer _renderer;
    private Color _startColor;
    private Color _nextColor;
    private float _currentTime;
    [SerializeField] private float _recoloringDuration;
    [SerializeField] private float _delayBeforeRecoloring;
    void Start()
    {
        _renderer = GetComponent<Renderer>();
        GenerateRandomColor();
    }

    
    void Update()
    {
        _currentTime += Time.deltaTime;
        var progress = _currentTime / _recoloringDuration;
        var newColor = Color.Lerp(_startColor, _nextColor, progress);
        _renderer.material.color = newColor;

        if (_currentTime > _recoloringDuration)
        {
            if (_currentTime > _delayBeforeRecoloring)
            {
                _currentTime = 0f;
                GenerateRandomColor();
            }
        }
    }

    private void GenerateRandomColor()
    {
        _startColor = _renderer.material.color;
        _nextColor = Random.ColorHSV(0f, 1f, 1f, 1f, 1f, 1f);
    }
    
}
