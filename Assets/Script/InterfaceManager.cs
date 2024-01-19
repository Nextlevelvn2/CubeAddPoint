using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InterfaceManager : MonoBehaviour
{
    [SerializeField] private Text pointText;
    public static InterfaceManager Instance;
    int totalPoint;
    private void Awake()
    {
        if(Instance != this && Instance != null)
        {
            Destroy(Instance);
        }
        else
        {
            Instance = this;
        }
    }
    public void UpdateUI(int amount)
    {
        totalPoint += amount;
        pointText.text = totalPoint.ToString();
    }

}
