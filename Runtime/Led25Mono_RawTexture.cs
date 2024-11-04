using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public enum Led25VerticalType
{
    DownTop,
    TopDown
}

public interface I_Led25GridGetterLRDT
{

    void GetLedAsPercent(int xLeftRight, int yDownTop, out float percent);
    void GetLedAsBool(int xLeftRight, int yDownTop, out bool isActive);
    void GetLedAs0To9(int xLeftRight, int yDownTop, out int value);
    
    void GetLedAs0To9(int indexTopDownArray25, out int value);
    void GetLedAsPercent(int indexTopDownArray25, out float value);
    void GetLedAsBool(int indexTopDownArray25, out bool value);
}
public interface I_Led25GridSetterLRDT
{
    void CopyLedFromInterface(I_Led25GridGetterLRDT grid);
    void SetLedWithInteger25BitsRightLeft(int integer);
    void SetLedAsPercent(int xLeftRight, int yDownTop, float percent);
    void SetLedAsBool(int xLeftRight, int yDownTop, bool isActive);
    void SetLedAs0To9(int xLeftRight, int yDownTop, int value);
    void SetLedAsPercent(int indexTopDownArray25, float value);
    void SetLedAsBool(int indexTopDownArray25, bool value);
    void SetLedAs0To9(int indexTopDownArray25, int value);
}

public interface I_Led25GridGetSetLRDT : I_Led25GridGetterLRDT, I_Led25GridSetterLRDT
{}

[System.Serializable]
public class Led25PercentDefault: I_Led25GridGetSetLRDT
{
    public STRUCT_Led25PercentLRDT m_gridPercentStateStruct;

    public void GetDownTopIndex(int xLeftRight, int yDownTop, out int index)=>
        index = xLeftRight + yDownTop * 5;

    public void GetLedAs0To9(int xLeftRight, int yDownTop, out int value)
    {
        
        GetDownTopIndex(xLeftRight, yDownTop, out int index);
        m_gridPercentStateStruct.GetLRDT(index, out float percent);
        value = Mathf.RoundToInt(percent * 9);
    }

    public void GetLedAs0To9(int indexTopDownArray25, out int value)
    {
        m_gridPercentStateStruct.GetLRDT(indexTopDownArray25, out float percent);
        value = Mathf.RoundToInt(percent * 9);
    }

    public void GetLedAsBool(int indexTopDownArray25, out bool value)
    {
        m_gridPercentStateStruct.GetLRDT(indexTopDownArray25, out value);
    }

    public void GetLedAsPercent(int indexTopDownArray25, out float value)
    {
        m_gridPercentStateStruct.GetLRDT(indexTopDownArray25, out value);
    }

    public void GetLedAsPercent(int xLeftRight, int yDownTop, out float percent)
    {
        GetDownTopIndex(xLeftRight, yDownTop, out int index);
        m_gridPercentStateStruct.GetLRDT(index, out percent);
    }

    public void GetLedAsBool(int xLeftRight, int yDownTop, out bool isActive)
    {
        GetDownTopIndex(xLeftRight, yDownTop, out int index);
        m_gridPercentStateStruct.GetLRDT(index, out isActive);
    }

    public void GetTopDownIndex(int xLeftRight, int yDownTop, out int index) =>
        index = xLeftRight + (4 - yDownTop) * 5;

    public void SetLedAsPercent(int xLeftRight, int yDownTop, float percent)
    {
        GetDownTopIndex(xLeftRight, yDownTop, out int index);
        SetLedAsPercent(index, percent);
    }

    public void SetLedAsBool(int xLeftRight, int yDownTop, bool isActive)
    {
        GetDownTopIndex(xLeftRight, yDownTop, out int index);
        SetLedAsBool(index, isActive);
    }

    public void SetLedAs0To9(int xLeftRight, int yDownTop, int value)
    {
        GetDownTopIndex(xLeftRight, yDownTop, out int index);
        SetLedAs0To9    (index, value);
    }

    public void SetLedAsPercent(int indexTopDownArray25, float value)
    {
        Mathf.Clamp01(value);
        m_gridPercentStateStruct.SetLRDT(indexTopDownArray25, value);
    }

    public void SetLedAsBool(int indexTopDownArray25, bool value)
    {
        m_gridPercentStateStruct.SetLRDT(indexTopDownArray25, value);
    }

    public void SetLedAs0To9(int indexTopDownArray25, int value)
    {
        float percent = value / 9f;
        Mathf.Clamp01(percent);
        SetLedAsPercent(indexTopDownArray25, percent);
    }

    public void CopyLedFromInterface(I_Led25GridGetterLRDT grid)
    {
        for (int i = 0; i < 25; i++)
        {
            grid.GetLedAsPercent(i, out float percent);
            SetLedAsPercent(i, percent);
        }
    }

    public void SetLedWithInteger25BitsRightLeft(int integer)
    {
        Led25GridUtility.SetLedWithInteger25BitsRightToLeft(this, integer);
    }
}


public class Led25Mono_RawTexture : MonoBehaviour
{


    public UnityEvent<Texture2D> m_onTextureRefreshed;
    public int m_ledWidth=4;
    public int m_ledWidthSpace = 16;
    public int m_ledHeight=5;
    public int m_ledHeightSpace =15;
    public int m_margin=4;

    int m_ledGrid25 = 25;

    [Header("Debug")]
    public Texture2D m_rawTexture;
    public int m_pixelWidth = 0;
    public int m_pixelHeight = 0;

    public Color m_ledColorHigh = new Color(1, 0, 0, 1);
    public Color m_ledColorLow = new Color(0.1f, 0, 0, 1);
    public Color m_background = new Color(0, 0, 0, 0);

    public float[] m_arrayValue = new float[25];


    public void SetWith(I_Led25GridGetterLRDT grid) { 
    
        for (int i = 0; i < m_ledGrid25; i++)
        {
            grid.GetLedAsPercent(i, out m_arrayValue[i]);
        }
        RefreshTexture();
    }

    public void Awake()
    {
        CreateTexture();
    }

    public void SetPixelStateDownTop(int xLeftright, int yDownTop, bool valueAsBoolean)
    {
        int index1D = xLeftright + yDownTop * 5;
        m_arrayValue[index1D] = valueAsBoolean ? 1 : 0;
    }
    public void SetPixelStateTopDown(int xLeftright, int yDownTop, bool valueAsBoolean)
    {
        int index1D = xLeftright + (4 - yDownTop) * 5;
        m_arrayValue[index1D] = valueAsBoolean ? 1 : 0;
    }
    public void SetPixelStateDownTop(int xLeftright, int yDownTop, float valueAsPercent)
    {
        int index1D = xLeftright + yDownTop * 5;
        m_arrayValue[index1D] = valueAsPercent ;
    }
    public void SetPixelStateTopDown(int xLeftright, int yDownTop, float valueAsPercent)
    {
        int index1D = xLeftright + (4 - yDownTop) * 5;
        m_arrayValue[index1D] = valueAsPercent;
    }

    public bool m_useUpdateToRefresh;
    public void Update()
    {
        if (m_useUpdateToRefresh)
            RefreshTexture();
    }


    public void SetWithPercentFloatArray25Pixels(float[] array)
    {
        if (array.Length != 25)
            return;
        m_arrayValue = array;
        RefreshTexture();
    }


    [ContextMenu("Try random Value")]
    public void TryRandomValue() { 
    
        for (int i = 0; i < m_ledGrid25; i++)
        {
            m_arrayValue[i] = UnityEngine.Random.value;
        }
        RefreshTexture();
    }

    [ContextMenu("Refresh Texture")]
    public void RefreshTexture()
    {
        if (m_rawTexture == null || (m_rawTexture.width != m_ledGrid25 || m_rawTexture.height != m_ledGrid25))
        {
            CreateTexture();
        }
        for (int i = 0; i < m_ledGrid25; i++)
        {
            int x = i % 5;
            int y = i / 5;


            for (int xPixel = 0; xPixel < m_ledWidth; xPixel++)
            {
                Color c = Color.Lerp(m_ledColorLow, m_ledColorHigh, m_arrayValue[i]);
                for (int yPixel = 0; yPixel < m_ledHeight; yPixel++)
                {
                    c.a= m_arrayValue[i]*9f;
                    int xPixelTexture = m_margin + x * m_ledWidthSpace + x * m_ledWidth + xPixel;
                    int yPixelTexture = m_margin + y * m_ledHeightSpace + y * m_ledHeight + yPixel;
                    m_rawTexture.SetPixel(xPixelTexture, yPixelTexture, c);
                }
            }

        }
        m_rawTexture.Apply();
        m_onTextureRefreshed.Invoke(m_rawTexture);
    }

    private void CreateTexture()
    {
        m_pixelWidth = m_margin * 2 + m_ledWidthSpace * 4 + m_ledWidth * 5;
        m_pixelHeight = m_margin * 2 + m_ledHeightSpace * 4 + m_ledHeight * 5;
        m_rawTexture = new Texture2D(m_pixelWidth, m_pixelHeight, TextureFormat.RGBA32, false);
        m_rawTexture.filterMode = FilterMode.Point;
        m_rawTexture.wrapMode = TextureWrapMode.Clamp;
      
        for(int x=0; x<m_pixelWidth; x++)
            for (int y = 0; y < m_pixelHeight; y++)
            {
                m_rawTexture.SetPixel(x, y, m_background);
            }
        m_rawTexture.Apply();
        m_onTextureRefreshed.Invoke(m_rawTexture);
    }
}
