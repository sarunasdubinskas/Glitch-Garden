using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSelector : MonoBehaviour
{

    [SerializeField] Defender defenderPrefab;

    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderSelector>();
        foreach(DefenderSelector button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(125, 125, 125, 255);
        }
        GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab);
    }
}
