using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    public static Score instance;
    [SerializeField] private TextMeshProUGUI _currentScoreText;
    [SerializeField] private TextMeshProUGUI _bestScoreText;

    private int _score;
    void Awake(){
        if(instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        _currentScoreText.text = _score.ToString();
        _bestScoreText.text = PlayerPrefs.GetInt("BestScore",0).ToString();
        UpdateBestScore();
    }
    
    public void UpdateBestScore(){
        if(_score > PlayerPrefs.GetInt("BestScore")){
            PlayerPrefs.SetInt("BestScore",_score);
            _bestScoreText.text = _score.ToString();
        }
    }

    public void UpdateScore(){
        _score++;
        _currentScoreText.text = _score.ToString();
        UpdateBestScore();
    }
}
