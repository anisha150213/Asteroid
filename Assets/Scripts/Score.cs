using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int _currentScore = 0;
    private TextMeshProUGUI _text;
    // Start is called before the first frame update
    void Start()
    {
        Bullet.OnAsteroidHit += UpdateScore;
        _text = GetComponent <TextMeshProUGUI>();
    }

    // Update is called once per frame
    void UpdateScore()
    {
        _currentScore++;
        _text.SetText($"Score: {_currentScore}");
    }

}
