using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeManager : MonoBehaviour, ICollectable
{
    int amountToAdd = 1;
    public void AddPoint()
    {
        InterfaceManager.Instance.UpdateUI(amountToAdd);
    }
}
