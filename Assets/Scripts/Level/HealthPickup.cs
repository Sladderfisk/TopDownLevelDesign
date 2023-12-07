using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : Interactable
{
    [SerializeField] private int healthOnPickup;

    private static Player player;

    private void OnEnable()
    {
        if (player != null) return;
        player = FindObjectOfType<Player>();
    }

    protected override void OnInteraction()
    {
        player.HealPlayer(healthOnPickup);
        Destroy(gameObject);
        Debug.Log("PickedUp");
    }
}
