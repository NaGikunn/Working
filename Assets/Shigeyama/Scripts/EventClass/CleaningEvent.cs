using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleaningEvent : MonoBehaviour,IGimmick
{
    //イベント発生時生成するアイコン
    [SerializeField]
    GameObject eventAlertIcon;

    bool isEvent;

    public void AICleanEvent()
    {
        Debug.Log("イベント発生");
    }

    /// <summary>
    /// プレイヤーがアクセスするメソッド
    /// </summary>
    /// <param name="player"></param>
    public void PlayGimmick(GameObject player)
    {
        // アクセスできるかどうか判断
        if (eventAlertIcon != null)
        {
            // プレイヤーがイベントを開始
            player.GetComponent<PlayerSystem>().IsEvent = true;

            // コルーチンを呼び出す
            StartCoroutine(PlayCleaning(player));
        }
    }

    /// <summary>
    /// イベント用コルーチン
    /// </summary>
    /// <param name="player"></param>
    /// <returns></returns>
    IEnumerator PlayCleaning(GameObject player)
    {
        // プレイヤーがアクションを行う時間
        float timeInterval = 5;
        // タイマーの計測
        eventAlertIcon.GetComponent<AlertIconManager>().PlayerActionTimer(timeInterval);
        // イベント時間計測
        yield return new WaitForSeconds(timeInterval);

        // プレイヤーが行動を終了
        player.GetComponent<PlayerSystem>().IsEvent = false;
        yield return null;
    }

    public bool GimmickIsEvent()
    {
        return isEvent;
    }
}
