using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingletonBase<GameManager>
{
    /// <summary>
    /// チームコスト 添え字が0,1のみ
    /// </summary>
    private float[] _currentCost;

    [SerializeField, Tooltip("初期コスト")] float _teamCost = 6000;
    protected override void DoAwake()
    {
        //チームコストを初期化する
        _currentCost = new float[2];
        for (int i = 0; i < 2; i++)
            _currentCost[i] = _teamCost;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// 機体が破壊されたときにコストを減らす処理
    /// </summary>
    /// <param name="cost">減らすコスト</param>
    /// <param name="team">チーム</param>
    public void CostDown(float cost, int team)
    {
        _currentCost[team] -= cost;
    }

    private void GameOver()
    {
        //ゲームオーバー処理
    }
}
