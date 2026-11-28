using UnityEngine;
/// <summary>
/// スポナークラス 
/// ----------------------
/// 指定したオフジェクトを、
/// 一定間隔でランダムな位置に出現させる。
/// </summary>
public class Enemy : MonoBehaviour
{
    // === フィールド === //
    [Header("* * * 出現時間 * * *")]
    [SerializeField]public GameObject _spawnPrefab;  // 出現するプレハブの指定
    [SerializeField] public float _spawnInterval;     // 出現間隔（秒）

    private float _spawnIntervalTimer;   // 時間計測用の変数
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 時間計測
        _spawnIntervalTimer += Time.deltaTime;

        // 一定時間ごとの判定
        if(_spawnIntervalTimer >= _spawnInterval)
        {
            Spawn();
            _spawnIntervalTimer = 0;
        }

    }

    /// <summary>
    /// 出現メソッド
    /// </summary>
    public void Spawn()
    {
        Vector3 spawnPoint = new Vector3(0f, 0f, 0f);
        spawnPoint.x = Random.Range(-5f, 5f);
        spawnPoint.y = 0.5f;
        spawnPoint.z = Random.Range(-5f, 5f);

        GameObject target = Instantiate(_spawnPrefab, spawnPoint, Quaternion.identity);
    }
}
