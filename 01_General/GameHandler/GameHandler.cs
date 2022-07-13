﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour {

    [Header("Attached Objects")]
    public GameObject Player;
    public InputField PlayerNameField;
    public InputField BattleNameField;

    // Variables
    [HideInInspector] public string playerName() { return PlayerNameField.text; }
    [HideInInspector] public string battleName() { return BattleNameField.text; }
    [HideInInspector] public List<string[]> joinableBattle = new List<string[]>();


    // Test Var
    [HideInInspector] public float posX() { return Mathf.Floor(Player.transform.position.x *10) /10; }
    [HideInInspector] public bool isAttacking() { return Player.GetComponent<PlayerAttack>().isAttacking; }
}
