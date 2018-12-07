﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardboardItem : MonoBehaviour, IItem
{
    Rigidbody rd;

    // 各アイテムの持った際の座標と回転を設定する変数
    Vector3 catchPosition;
    Vector3 catchRotation;

    Vector3 playerColliderSize;
    Vector3 playerColliderCenter;

    Vector3 playerColliderIsTriggerSize;
    Vector3 playerColliderIsTriggerCenter;

    bool isCatch = false;

    // Use this for initialization
    void Awake()
    {
        rd = GetComponent<Rigidbody>();

        catchPosition = new Vector3(0.0f, 0.5f, 0.6f);
        catchRotation = new Vector3(0.0f, 90.0f, 0.0f);

        playerColliderSize = new Vector3(0.8f, 1.4f, 1.3f);
        playerColliderCenter = new Vector3(0.0f, 0.8f, 0.3f);

        playerColliderIsTriggerSize = new Vector3(1.2f, 1.0f, 0.5f);
        playerColliderIsTriggerCenter = new Vector3(0.0f, 0.8f, 1.0f);
    }

    // 段ボール側でプレイヤーがアクセスする機能をつける場合はここに書くといいはず
    public void PlayItem(GameObject player)
    {

    }

    public Vector3 LocalPosition()
    {
        return catchPosition;
    }

    public Vector3 LocalRotation()
    {
        return catchRotation;
    }

    public Vector3 PlayerColliderSize()
    {
        return playerColliderSize;
    }

    public Vector3 PlayerColliderCenter()
    {
        return playerColliderCenter;
    }

    public Vector3 PlayerColliderIsTriggerSize()
    {
        return playerColliderIsTriggerSize;
    }

    public Vector3 PlayerColliderIsTriggerCenter()
    {
        return playerColliderIsTriggerCenter;
    }

    public bool isItemCatch
    {
        get { return isCatch; }
        set { isCatch = value; }
    }
}
