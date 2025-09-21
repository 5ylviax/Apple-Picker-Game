using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class RoundsCheck : MonoBehaviour
{
    public static RoundsCheck Instance;

    public int currentRound = 1;
    public int maxRounds = 4;
    public TMP_Text roundText; // TMP text UI element
    public float baseDropDelay = 1f;
    public float speedIncrease = 0.2f;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject); // prevent duplicates
            return;
        }
        Instance = this;
    }

    private void Start()
    {
        UpdateUI();
    }

    // Called by ScoreCounter when score changes
    public void CheckLevelProgress(int score)
    {
        if (score <= 1000)
        {
            currentRound = 1;
        }
        else if (score <= 1500)
        {
            currentRound = 2;
        }
        else if (score <= 2000)
        {
            currentRound = 3;
        }
        else if (score <= 2500)
        {
            currentRound = 4;
        }
        else if (score >= 3000)
        {

        }
        currentRound = Mathf.Clamp(currentRound, 1, maxRounds);

        UpdateUI();
    }

    private void UpdateUI()
    {
        if (roundText == null)
        {
            Debug.LogError("roundText is not assigned in the Inspector!");
            return;
        }

        Debug.Log($"Updating UI: Round {currentRound} / {maxRounds}");
        roundText.text = $"Round {currentRound} / {maxRounds}";
    }

    public float GetDropDelay()
    {
        return baseDropDelay - (currentRound - 1) * speedIncrease;
    }
}
