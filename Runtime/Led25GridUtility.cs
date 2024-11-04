using Eloi.Led25;
using System;
using UnityEngine;

public static class Led25GridUtility {


    public static void SetAsEmpty(I_Led25GridSetterLRDT grid)
    {
        for (int i = 0; i < C_25; i++)
        {
            grid.SetLedAsPercent(i, 0);
        }
    }

    public static void SetAsFull(I_Led25GridSetterLRDT grid)
    {
        for (int i = 0; i < C_25; i++)
        {
            grid.SetLedAsPercent(i, 1);
        }
    }

    public static void DrawLineHorizontalDT(I_Led25GridSetterLRDT grid, int yDownTop, float percent) { 
        for (int i = 0; i < C_5; i++) { 
            grid.SetLedAsPercent(i, yDownTop, percent); 
        } 
    }
    public static void DrawLineVerticalLR(I_Led25GridSetterLRDT grid, int xLeftRight, float percent) { 
        for (int i = 0; i < C_5; i++) { 
            grid.SetLedAsPercent(xLeftRight, i, percent); 
        } 
    }

    public static void SetAsLargeShield(I_Led25GridSetterLRDT grid,float value) { 
        SetAsEmpty(grid); 
        DrawAsLargeShield(grid, value); 
    }    
    public static void DrawAsLargeShield(I_Led25GridSetterLRDT grid, float value) {
        DrawLineHorizontalDT(grid, 0, value);
        DrawLineHorizontalDT(grid, 4, value);
        DrawLineVerticalLR(grid, 0, value);
        DrawLineVerticalLR(grid, 4, value);
    }

    public static void SetSinglePixel(I_Led25GridSetterLRDT grid, float value) { 
        SetAsEmpty(grid); 
        DrawSinglePixel(grid, value); 
    }
    public static void DrawSinglePixel(I_Led25GridSetterLRDT grid, float value) { 
        grid.SetLedAsPercent(2, 2, value); 
    }

    public static void SetAsSmallCross(I_Led25GridSetterLRDT grid, float value, bool centerEmpty) { 
        SetAsEmpty(grid); 
        DrawSmallCross(grid, value, centerEmpty); 
    }
    public static void DrawSmallCross(I_Led25GridSetterLRDT grid,float value, bool centerEmpty)
    {
        grid.SetLedAsPercent(2, 1, value);
        grid.SetLedAsPercent(1, 2, value);
        grid.SetLedAsPercent(3, 2, value);
        grid.SetLedAsPercent(2, 3, value);
        grid.SetLedAsPercent(2, 2, centerEmpty?0:value);
    }

    public static void SetAsLargeCross(I_Led25GridSetterLRDT grid, float value, bool centerEmpty)
    {
        SetAsEmpty(grid);
        DrawLargeCross(grid, value, centerEmpty);
    }

    public static void DrawLargeCross(I_Led25GridSetterLRDT grid,float value ,bool centerEmpty)
    {
        DrawLineHorizontalDT(grid, 2, value);
        DrawLineVerticalLR(grid, 2, value);
        grid.SetLedAsPercent(2, 2, centerEmpty ? 0 : value);
    }
    
    public static void SetAsRandomPercent(I_Led25GridSetterLRDT grid, float value)
    {
        for (int i = 0; i < C_25; i++)
        {
            grid.SetLedAsPercent(i, UnityEngine.Random.value);
        }
    }

    public static void SetAsRandomBoolean(I_Led25GridSetterLRDT grid, float value)
    {

        for (int i = 0; i < C_25; i++)
        {
            grid.SetLedAsBool(i, UnityEngine.Random.value > 0.5f);
        }
    }

    public static void SetSmallShield(I_Led25GridSetterLRDT grid, float value)
    {
        SetAsEmpty(grid);
        DrawSmallShield(grid, value);
    }
    public static void DrawSmallShield(I_Led25GridSetterLRDT grid, float value)
    {
        grid.SetLedAsPercent(1, 1, value);
        grid.SetLedAsPercent(1, 2, value);
        grid.SetLedAsPercent(1, 3, value);
        grid.SetLedAsPercent(2, 1, value);
        grid.SetLedAsPercent(2, 3, value);
        grid.SetLedAsPercent(3, 1, value);
        grid.SetLedAsPercent(3, 2, value);
        grid.SetLedAsPercent(3, 3, value);
    }

    public static void GetDefaultPixelDirectionAsBool(I_Led25GridGetterLRDT grid, out float xLeftRight11, out float yDownTop11)
    {
        Vector2 direction = new Vector2();
        for(int x = 0; x < C_5; x++)
        {
            for (int y = 0; y < C_5; y++)
            {
                grid.GetLedAsBool(x, y, out bool isActive);
                if (isActive)
                {
                    if(x<2)
                    {
                        direction.x += -1;
                    }
                    else if(x>2)
                    {
                        direction.x += 1;
                    }

                    if (y < 2)
                    {
                        direction.y += -1;
                    }
                    else if (y > 2)
                    {
                        direction.y += 1;
                    }
                }
            }
        }
        direction.Normalize();
        xLeftRight11 = direction.x;
        yDownTop11 = direction.y;
    }


    public static void SetWallTop(I_Led25GridSetterLRDT grid, float value)
    {
        SetAsEmpty(grid);
        DrawWallTop(grid, value);
    }

    public static void DrawWallTop(I_Led25GridSetterLRDT grid, float value)
    {
        DrawLineHorizontalDT(grid, 4, value);
    }
    public static void SetWallRight(I_Led25GridSetterLRDT grid, float value)
    {
        SetAsEmpty(grid);
        DrawWallRight(grid, value);
    }

    public static void DrawWallRight(I_Led25GridSetterLRDT grid, float value)
    {
        DrawLineVerticalLR(grid, 4, value);
    }

    public static void SetWallBottom(I_Led25GridSetterLRDT grid, float value)
    {
        SetAsEmpty(grid);
        DrawWallBottom(grid, value);
    }
    public static void DrawWallBottom(I_Led25GridSetterLRDT grid, float value)
    {
        DrawLineHorizontalDT(grid, 0, value);
    }

    public static void SetWallLeft(I_Led25GridSetterLRDT grid, float value)
    {
        SetAsEmpty(grid);
        DrawWallLeft(grid, value);
    }
    public static void DrawWallLeft(I_Led25GridSetterLRDT grid, float value)
    {
        DrawLineVerticalLR(grid, 0, value);
    }

    public static void SetLedWithInteger25BitsRightToLeft(I_Led25GridSetterLRDT grid, int integer)
    {
        Led25GridUtility.GetIntegerAs32BitsRightLeft(integer, out bool[] bit32);
        for (int i = 0; i < C_25; i++)
        {
            Led25GridUtility.Index1DToXYTopDownLeftRight(i, out int x, out int y);
            bool isActive = bit32[i + 7];
            grid.SetLedAsPercent(x, y, isActive ? 1 : 0);
        }
    }
    public static void SetLedWithInteger25BitsRightToLeft(out STRUCT_Led25PercentLRDT grid, int integer)
    {
        grid = new STRUCT_Led25PercentLRDT();
        Led25GridUtility.GetIntegerAs32BitsRightLeft(integer, out bool[] bit32);
        for (int i = 0; i < C_25; i++)
        {
            Led25GridUtility.Index1DToXYTopDownLeftRight(i, out int x, out int y);
            bool isActive = bit32[i + 7];
            grid.SetLRDT(i, isActive ? 1 : 0);
        }
    }


    public static void SetWithText(I_Led25GridSetterLRDT grid, string text)
    {
        text= text.Replace("\n", "").Replace("\r", "").Replace("\t", "").Replace(" ", "");
        Debug.Log(text);
        for (int i = 0; i < C_25; i++)
        {
            Led25GridUtility.Index1DToXYTopDownLeftRight(i, out int x, out int y);

            if (i >= text.Length)
            {
                grid.SetLedAsPercent(x,y ,0);
            }
            else
            {
                if (text[i]=='_' || text[i]=='0')
                {
                    grid.SetLedAsPercent(x,y, 0);
                }
                else if (byte.TryParse(text[i].ToString(), out byte result))
                {
                    float percent = ((float)result) / 9.0f;
                    grid.SetLedAsPercent(x, y, percent);
                }
                else { 
                    grid.SetLedAsPercent(x, y, 1);
                }
            }
        }

    }

    public static void Index1DToXYDownTopLeftRight(int indexLinear1D, out int x, out int y)
    {
        x = 2;
        y = 2;
        switch (indexLinear1D)
        {
            case 0: x = 0; y = 4; break;
            case 1: x = 1; y = 4; break;
            case 2: x = 2; y = 4; break;
            case 3: x = 3; y = 4; break;
            case 4: x = 4; y = 4; break;
            case 5: x = 0; y = 3; break;
            case 6: x = 1; y = 3; break;
            case 7: x = 2; y = 3; break;
            case 8: x = 3; y = 3; break;
            case 9: x = 4; y = 3; break;
            case 10: x = 0; y = 2; break;
            case 11: x = 1; y = 2; break;
            case 12: x = 2; y = 2; break;
            case 13: x = 3; y = 2; break;

            case 14: x = 4; y = 2; break;
            case 15: x = 0; y = 1; break;
            case 16: x = 1; y = 1; break;
            case 17: x = 2; y = 1; break;
            case 18: x = 3; y = 1; break;
            case 19: x = 4; y = 1; break;
            case 20: x = 0; y = 0; break;
            case 21: x = 1; y = 0; break;
            case 22: x = 2; y = 0; break;
            case 23: x = 3; y = 0; break;
            case 24: x = 4; y = 0; break;


        }
    }

    public static void  Index1DToXYTopDownLeftRight(int indexLinear1D, out int x, out int y)
    {
       
        x = 2;
        y = 2;
        switch (indexLinear1D)
        {
            case 0: x = 0; y = 0; break;
            case 1: x = 1; y = 0; break;
            case 2: x = 2; y = 0; break;
            case 3: x = 3; y = 0; break;
            case 4: x = 4; y = 0; break;
            case 5: x = 0; y = 1; break;
            case 6: x = 1; y = 1; break;
            case 7: x = 2; y = 1; break;
            case 8: x = 3; y = 1; break;
            case 9: x = 4; y = 1; break;
            case 10: x = 0; y = 2; break;
            case 11: x = 1; y = 2; break;
            case 12: x = 2; y = 2; break;
            case 13: x = 3; y = 2; break;
            case 14: x = 4; y = 2; break;
            case 15: x = 0; y = 3; break;
            case 16: x = 1; y = 3; break;
            case 17: x = 2; y = 3; break;
            case 18: x = 3; y = 3; break;
            case 19: x = 4; y = 3; break;
            case 20: x = 0; y = 4; break;
            case 21: x = 1; y = 4; break;
            case 22: x = 2; y = 4; break;
            case 23: x = 3; y = 4; break;
            case 24: x = 4; y = 4; break;
        }
    }

    public static void GetIntegerAs32BitsLeftRight(int value, out bool[] bits32)
    {
        // from right to left
        bits32 = new bool[32];
        for (int i = 0; i < 32; i++)
        {
            bits32[i] = (value & (1 << i)) != 0;
        }
    }
    public static void GetIntegerAs32BitsRightLeft(int value, out bool[] bits32)
    {
        GetIntegerAs32BitsLeftRight(value, out bits32);
        Array.Reverse(bits32);
    }
    public static void GetIntegerAs32BitsRightLeft(int value, out char[] bit32RLChar)
    {
        GetIntegerAs32BitsRightLeft(value, out bool[] bits32R2L);
        bit32RLChar = new char[32];
        for (int i = 0; i < bit32RLChar.Length; i++)
        {
            bit32RLChar[i] = bits32R2L[i] ? '1' : '0';
        }
    }
    public static void GetIntegerAs32BitsRightLeft(int value, out string bit32RLChar)
    {
        GetIntegerAs32BitsRightLeft(value, out char[ ] chars);
        bit32RLChar = new string(chars);
        
    }

    public static void GetIntegerFrom32BitsRightLeft(bool[] m_bitsOfInteger, out int integer)
    {
        integer = 0;
        
        for (int i = 0; i < 32; i++)
        {
            int index= 31-i;
            bool isTrue = m_bitsOfInteger[index];
            if (isTrue)
            {
                IntPow2(i,out int pow);
                integer += pow;
            }
        }
    }
    public static void IntPow2(int index, out int result)
    {
        result = 1;
        for (int i = 0; i < index; i++)
        {
            result *= 2;
        }
    }

    public static void SetLedWith25BitsTopLeftToDownRight(I_Led25GridSetterLRDT grid, bool[] booleans)
    {
        for (int i = 0; i < C_25; i++)
        {
            Index1DToXYTopDownLeftRight(i, out int x, out int y);
            Led25GridUtility.InverseY(ref y);
            grid.SetLedAsBool(x, y, booleans[i]);
        }
    }

    public static void InverseY(ref int y)
    {
        y = C_5 - 1 - y;
    }

    public static readonly int C_25 = 25;
    public static readonly int C_5 = 5;
}