using Naninovel;
using Naninovel.UI;
using UnityEngine;
using UnityEngine.UI;

public class MiniGameUI : CustomUI
{
    private bool _started;
    private float _timer;

    void Start()
    {
        _started = false;
        _timer = 5f;
    }

    void FixedUpdate()
    {
        if (_started)
        {
            _timer -= Time.deltaTime;
        }
    }
    
    public UniTask StartMiniGame()
    {
        _started = true;

        while (_timer >= 0)
        {
            Debug.Log(_timer.ToString());
        }
        
        return UniTask.CompletedTask;
    }
}
