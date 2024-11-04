[System.Serializable]
public struct STRUCT_Led25Bool
{
    public bool m_ledLeftRight0DownTop0;
    public bool m_ledLeftRight1DownTop0;
    public bool m_ledLeftRight2DownTop0;
    public bool m_ledLeftRight3DownTop0;
    public bool m_ledLeftRight4DownTop0;
    public bool m_ledLeftRight0DownTop1;
    public bool m_ledLeftRight1DownTop1;
    public bool m_ledLeftRight2DownTop1;
    public bool m_ledLeftRight3DownTop1;
    public bool m_ledLeftRight4DownTop1;
    public bool m_ledLeftRight0DownTop2;
    public bool m_ledLeftRight1DownTop2;
    public bool m_ledLeftRight2DownTop2;
    public bool m_ledLeftRight3DownTop2;
    public bool m_ledLeftRight4DownTop2;
    public bool m_ledLeftRight0DownTop3;
    public bool m_ledLeftRight1DownTop3;
    public bool m_ledLeftRight2DownTop3;
    public bool m_ledLeftRight3DownTop3;
    public bool m_ledLeftRight4DownTop3;
    public bool m_ledLeftRight0DownTop4;
    public bool m_ledLeftRight1DownTop4;
    public bool m_ledLeftRight2DownTop4;
    public bool m_ledLeftRight3DownTop4;
    public bool m_ledLeftRight4DownTop4;


    public void SetValeu(int index, bool isActive) {
            switch (index)
            {
                case 0: m_ledLeftRight0DownTop4 = isActive; break;
                case 1: m_ledLeftRight1DownTop4 = isActive; break;
                case 2: m_ledLeftRight2DownTop4 = isActive; break;
                case 3: m_ledLeftRight3DownTop4 = isActive; break;
                case 4: m_ledLeftRight4DownTop4 = isActive; break;
                case 5: m_ledLeftRight0DownTop3 = isActive; break;
                case 6: m_ledLeftRight1DownTop3 = isActive; break;
                case 7: m_ledLeftRight2DownTop3 = isActive; break;
                case 8: m_ledLeftRight3DownTop3 = isActive; break;
                case 9: m_ledLeftRight4DownTop3 = isActive; break;
                case 10: m_ledLeftRight0DownTop2 = isActive; break;
                case 11: m_ledLeftRight1DownTop2 = isActive; break;
                case 12: m_ledLeftRight2DownTop2 = isActive; break;
                case 13: m_ledLeftRight3DownTop2 = isActive; break;
                case 14: m_ledLeftRight4DownTop2 = isActive; break;
                case 15: m_ledLeftRight0DownTop1 = isActive; break;
                case 16: m_ledLeftRight1DownTop1 = isActive; break;
                case 17: m_ledLeftRight2DownTop1 = isActive; break;
                case 18: m_ledLeftRight3DownTop1 = isActive; break;
                case 19: m_ledLeftRight4DownTop1 = isActive; break;
                case 20: m_ledLeftRight0DownTop0 = isActive; break;
                case 21: m_ledLeftRight1DownTop0 = isActive; break;
                case 22: m_ledLeftRight2DownTop0 = isActive; break;
                case 23: m_ledLeftRight3DownTop0 = isActive; break;
                case 24: m_ledLeftRight4DownTop0 = isActive; break;
        }
    }

    public void GetValue(int index, out bool isActive) {
        switch (index)
        {
            case 0: isActive = m_ledLeftRight0DownTop4; break;
            case 1: isActive = m_ledLeftRight1DownTop4; break;
            case 2: isActive = m_ledLeftRight2DownTop4; break;
            case 3: isActive = m_ledLeftRight3DownTop4; break;
            case 4: isActive = m_ledLeftRight4DownTop4; break;
            case 5: isActive = m_ledLeftRight0DownTop3; break;
            case 6: isActive = m_ledLeftRight1DownTop3; break;
            case 7: isActive = m_ledLeftRight2DownTop3; break;
            case 8: isActive = m_ledLeftRight3DownTop3; break;
            case 9: isActive = m_ledLeftRight4DownTop3; break;
            case 10: isActive = m_ledLeftRight0DownTop2; break;
            case 11: isActive = m_ledLeftRight1DownTop2; break;
            case 12: isActive = m_ledLeftRight2DownTop2; break;
            case 13: isActive = m_ledLeftRight3DownTop2; break;
            case 14: isActive = m_ledLeftRight4DownTop2; break;
            case 15: isActive = m_ledLeftRight0DownTop1; break;
            case 16: isActive = m_ledLeftRight1DownTop1; break;
            case 17: isActive = m_ledLeftRight2DownTop1; break;
            case 18: isActive = m_ledLeftRight3DownTop1; break;
            case 19: isActive = m_ledLeftRight4DownTop1; break;
            case 20: isActive = m_ledLeftRight0DownTop0; break;
            case 21: isActive = m_ledLeftRight1DownTop0; break;
            case 22: isActive = m_ledLeftRight2DownTop0; break;
            case 23: isActive = m_ledLeftRight3DownTop0; break;
            case 24: isActive = m_ledLeftRight4DownTop0; break;
            default: isActive = false; break;
        }
    }
}
