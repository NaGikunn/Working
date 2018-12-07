using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GamepadInput;

public class EntrySystem : SingletonMonoBehaviour<EntrySystem>
{
    public enum PLAYERNUM
    {
        ONE,
        TWO,
        THREE,
        FOUR
    }

    // 実際は-1スタート
    public static int[] playerNumber = { 1, -1, -1, -1 };
    //public static int[] playerNumber = { -1, -1, -1, -1 };

    int playerCount = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (playerCount < 4)
        {
            // int = 0 かも?
            for (int i = 1; i < 5; i++)
            {
                //各プレイヤーの対応コントローラーを設定する
                if (GamePad.GetButtonDown(GamePad.Button.A, (GamePad.Index)i))
                {
                    SetPlayerNumber((PLAYERNUM)i);
                }
            }
        }

        if (playerCount > 0)
        {
            // int = 0 かも?
            for (int i = 1; i < 5; i++)
            {
                //各プレイヤーの対応コントローラーを解除する
                if (GamePad.GetButtonDown(GamePad.Button.B, (GamePad.Index)i))
                {
                    ReleasePlayerNumber((PLAYERNUM)i);
                }

                if (GamePad.GetButtonDown(GamePad.Button.Y, (GamePad.Index)i))
                {
                    ReleasePlayerNumber((PLAYERNUM)i);
                }
            }
        }
    }

    private void SetPlayerNumber(PLAYERNUM _player)
    {
        bool flg = false;

        //登録済みのコントローラーかを調べる
        foreach (int _number in playerNumber)
        {
            //登録済みの場合は、登録できない
            if (_number == (int)_player)
            {
                flg = true;

                Debug.Log("登録できません");
            }
        }

        if (!flg)
        {
            //コントローラー番号を1Pから割り当てる
            playerNumber[playerCount] = (int)_player;

            Debug.Log((PLAYERNUM)playerCount + " Player 登録完了");

            EntryCanvas.Instance.EntryDone(playerCount);

            playerCount++;
        }
    }

    private void ReleasePlayerNumber(PLAYERNUM _player)
    {
        for (int i = 0; i < playerNumber.Length; i++)
        {
            if ((int)_player == playerNumber[i])
            {
                playerNumber[i] = -1;
                playerCount--;
            }
        }

        List<int> array = new List<int>();
        int[] temp = { -1, -1, -1, -1 };

        for (int i = 0; i < playerNumber.Length; i++)
        {
            if (playerNumber[i] != -1)
            {
                array.Add(playerNumber[i]);
            }
        }

        for (int i = 0; i < array.Count; i++)
        {
            temp[i] = array[i];
        }

        for (int i = 0; i < temp.Length; i++)
        {
            playerNumber[i] = temp[i];
            Debug.Log(playerNumber[i]);

            EntryCanvas.Instance.EntryRelease(i, playerNumber[i]);
        }
    }
}
