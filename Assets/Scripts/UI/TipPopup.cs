using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class TipPopup : Popup
{
    public FloatReference tipCounter;
    public TMP_Text tipText;
    public override void InitPopup()
    {
        gameObject.SetActiveFast(false);
    }

    public void OnTipChanged()
    {
        UpdateTips();
    }

    private void UpdateTips()
    {
        float roundedValue = Mathf.Round(tipCounter * 100f) / 100f;
        tipText.SetText("Tips: $"+roundedValue);
    }
    
    public override void ShowPopup()
    {
        gameObject.SetActiveFast(true);
    }

    public override void HidePopup()
    {
        gameObject.SetActiveFast(false);
    }
}
