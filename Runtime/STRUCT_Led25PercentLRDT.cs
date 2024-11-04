[System.Serializable]
public struct STRUCT_Led25PercentLRDT
{
    public float m_ledLeftRight0DownTop0;
    public float m_ledLeftRight1DownTop0;
    public float m_ledLeftRight2DownTop0;
    public float m_ledLeftRight3DownTop0;
    public float m_ledLeftRight4DownTop0;
    public float m_ledLeftRight0DownTop1;
    public float m_ledLeftRight1DownTop1;
    public float m_ledLeftRight2DownTop1;
    public float m_ledLeftRight3DownTop1;
    public float m_ledLeftRight4DownTop1;
    public float m_ledLeftRight0DownTop2;
    public float m_ledLeftRight1DownTop2;
    public float m_ledLeftRight2DownTop2;
    public float m_ledLeftRight3DownTop2;
    public float m_ledLeftRight4DownTop2;
    public float m_ledLeftRight0DownTop3;
    public float m_ledLeftRight1DownTop3;
    public float m_ledLeftRight2DownTop3;
    public float m_ledLeftRight3DownTop3;
    public float m_ledLeftRight4DownTop3;
    public float m_ledLeftRight0DownTop4;
    public float m_ledLeftRight1DownTop4;
    public float m_ledLeftRight2DownTop4;
    public float m_ledLeftRight3DownTop4;
    public float m_ledLeftRight4DownTop4;

    public void GetValueLRDT(int index, out float percent)
    {
        percent = 0;
        if (index < 0 || index > 24)
            return;
        switch (index) { 
                case 0: percent = m_ledLeftRight0DownTop4; break;
                case 1: percent = m_ledLeftRight1DownTop4; break;
                case 2: percent = m_ledLeftRight2DownTop4; break;
                case 3: percent = m_ledLeftRight3DownTop4; break;
                case 4: percent = m_ledLeftRight4DownTop4; break;
                case 5: percent = m_ledLeftRight0DownTop3; break;
                case 6: percent = m_ledLeftRight1DownTop3; break;
                case 7: percent = m_ledLeftRight2DownTop3; break;
                case 8: percent = m_ledLeftRight3DownTop3; break;
                case 9: percent = m_ledLeftRight4DownTop3; break;
                case 10: percent = m_ledLeftRight0DownTop2; break;
                case 11: percent = m_ledLeftRight1DownTop2; break;
                case 12: percent = m_ledLeftRight2DownTop2; break;
                case 13: percent = m_ledLeftRight3DownTop2; break;
                case 14: percent = m_ledLeftRight4DownTop2; break;
                case 15: percent = m_ledLeftRight0DownTop1; break;
                case 16: percent = m_ledLeftRight1DownTop1; break;
                case 17: percent = m_ledLeftRight2DownTop1; break;
                case 18: percent = m_ledLeftRight3DownTop1; break;
                case 19: percent = m_ledLeftRight4DownTop1; break;
                case 20: percent = m_ledLeftRight0DownTop0; break;
                case 21: percent = m_ledLeftRight1DownTop0; break;
                case 22: percent = m_ledLeftRight2DownTop0; break;
                case 23: percent = m_ledLeftRight3DownTop0; break;
                case 24: percent = m_ledLeftRight4DownTop0; break;
                default: percent = 0; break;
        }
    }

    public void SetValueLRDT(int index, float value) {

        switch (index)
        {
            case 0: m_ledLeftRight0DownTop4 = value; break;
            case 1: m_ledLeftRight1DownTop4 = value; break;
            case 2: m_ledLeftRight2DownTop4 = value; break;
            case 3: m_ledLeftRight3DownTop4 = value; break;
            case 4: m_ledLeftRight4DownTop4 = value; break;
            case 5: m_ledLeftRight0DownTop3 = value; break;
            case 6: m_ledLeftRight1DownTop3 = value; break;
            case 7: m_ledLeftRight2DownTop3 = value; break;
            case 8: m_ledLeftRight3DownTop3 = value; break;
            case 9: m_ledLeftRight4DownTop3 = value; break;
            case 10: m_ledLeftRight0DownTop2 = value; break;
            case 11: m_ledLeftRight1DownTop2 = value; break;
            case 12: m_ledLeftRight2DownTop2 = value; break;
            case 13: m_ledLeftRight3DownTop2 = value; break;
            case 14: m_ledLeftRight4DownTop2 = value; break;
            case 15: m_ledLeftRight0DownTop1 = value; break;
            case 16: m_ledLeftRight1DownTop1 = value; break;
            case 17: m_ledLeftRight2DownTop1 = value; break;
            case 18: m_ledLeftRight3DownTop1 = value; break;
            case 19: m_ledLeftRight4DownTop1 = value; break;
            case 20: m_ledLeftRight0DownTop0 = value; break;
            case 21: m_ledLeftRight1DownTop0 = value; break;
            case 22: m_ledLeftRight2DownTop0 = value; break;
            case 23: m_ledLeftRight3DownTop0 = value; break;
            case 24: m_ledLeftRight4DownTop0 = value; break;
        }
    }

    //To Check
    public void GetValueLRDT(int xLeftRight, int yDownTop, out bool isActive)
    {
        int index = xLeftRight + yDownTop * 5;
        float percent = 0;
        GetValueLRDT(index, out percent);
        isActive = percent > 0.5f;
    }
    //To Check
    public void SetValueLRDT(int xLeftRight, int yDownTop, bool isActive)
    {
        int index = xLeftRight + yDownTop * 5;
        float percent = isActive ? 1 : 0;
        SetValueLRDT(index, percent);
    }

    public void GetLRDT(int xLeftRight, int yDownTop, out float percent)
    {
        int index = xLeftRight + yDownTop * 5;
        GetValueLRDT(index, out percent);
    }

    public void SetLRDT(int xLeftRight, int yDownTop, float percent)
    {
        int index = xLeftRight + yDownTop * 5;
        SetValueLRDT(index, percent);
    }


    public void GetLRDT(int index, out float percent)
    {
        GetValueLRDT(index, out percent);
    }
    public void SetLRDT(int index, float percent)
    {
        SetValueLRDT(index, percent);
    }

    public void GetLRDT(int index, out bool isActive)
    {
        float percent = 0;
        GetValueLRDT(index, out percent);
        isActive = percent > 0.5f;
    }
    public void SetLRDT(int index, bool isActive)
    {
        float percent = isActive ? 1 : 0;
        SetValueLRDT(index, percent);
    }
}
