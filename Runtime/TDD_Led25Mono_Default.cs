using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Eloi.Led25;
using UnityEngine.Events;
public class TDD_Led25Mono_Default : MonoBehaviour
{
    public UnityEvent<I_Led25GridGetSetLRDT> m_onPush;
    public Led25PercentDefault m_value;

    public int m_setWithInteger=1265464578;
    public bool[] m_bitsOfInteger;
    public int m_recoveredInteger;
  
    public string m_integerAsBinary;
    [TextArea(5, 6)]
    public string m_integerAsBinaryMultiline;

    public string m_setWithStringLine = "0999090009005009999990009";


    [TextArea(5, 6)]
    public string m_setWithStringText = @"
        09990
        90009
        00500
        90009
        90009";


    public void OnValidate()
    {
        RefreshIntegerDebugAsBits();

    }

    private void RefreshIntegerDebugAsBits()
    {
        Led25GridUtility.GetIntegerAs32BitsRightLeft(m_setWithInteger, out m_bitsOfInteger);
        Led25GridUtility.GetIntegerAs32BitsRightLeft(m_setWithInteger, out m_integerAsBinary);
        Led25GridUtility.GetIntegerFrom32BitsRightLeft(m_bitsOfInteger, out m_recoveredInteger);
        m_integerAsBinary= m_integerAsBinary.Substring(7,25);
        string t = "";
        for(int i = 0; i < 25; i++)
        {
            t += m_bitsOfInteger[7+i] ? "1" : "0";
            if( i==4 || i == 9 || i == 14 || i == 19)
            {
                t += "\n";
            }
        }
        m_integerAsBinaryMultiline = t;
    }

    [ContextMenu("Push Data")]
    public void PushData()
    {
        m_onPush.Invoke(m_value);
    }

    [ContextMenu("Push Integer")]
    public void PushInteger()
    {
        RefreshIntegerDebugAsBits();
        Led25GridUtility.SetLedWithInteger25BitsRightToLeft(m_value, m_setWithInteger);
        m_onPush.Invoke(m_value);
    }
    [ContextMenu("Push As Multiline Text")]
    public void PushAsMultilineText()
    {
        Led25GridUtility.SetWithText(m_value, m_setWithStringText);
        m_onPush.Invoke(m_value);
    }
    [ContextMenu("Push As One Line Text")]
    public void PushAsOneLine()
    {
        Led25GridUtility.SetWithText(m_value, m_setWithStringLine);
        m_onPush.Invoke(m_value);
    }
}
