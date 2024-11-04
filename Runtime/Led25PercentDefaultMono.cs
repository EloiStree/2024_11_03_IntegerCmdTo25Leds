using System;
using UnityEngine;
using UnityEngine.Events;


namespace Eloi.Led25
{


    public class Led25PercentDefaultMono : AbstractLed25GridLRDTMono
    {
        public Led25PercentDefault m_gridStateContainer;
        public UnityEvent< I_Led25GridGetSetLRDT> m_onManualPushed;
        public static readonly int m_25 = 25;
        public static readonly int m_5 = 5;

        public void Awake()
        {
            SetSinglePixel();
        }
        

        

        [ContextMenu("Set/Wall Left")]
        public void SetWallLeft()
        {
            Led25GridUtility.SetAsEmpty(this);
            Led25GridUtility.SetWallLeft(this, 1);
            PushValueAsEvent();
        }

        [ContextMenu("Set/Wall Right")]
        public void SetWallRight()
        {
            Led25GridUtility.SetAsEmpty(this);
            Led25GridUtility.SetWallRight(this,1);
            PushValueAsEvent();
        }

        [ContextMenu("Set/Wall Top")]
        public void SetWallTop()
        {
            Led25GridUtility.SetAsEmpty(this);
            Led25GridUtility.SetWallTop(this, 1);
            PushValueAsEvent();
        }

        [ContextMenu("Set/Wall Bottom")]
        public void SetWallBottom()
        {
            Led25GridUtility.SetAsEmpty(this);
            Led25GridUtility.SetWallBottom(this, 1);
            PushValueAsEvent();
        }


        [ContextMenu("Set/As Event")]
        public void PushValueAsEvent()
        {
            m_onManualPushed.Invoke(this);
        }

        [ContextMenu("Set/Empty Value")]
        public void SetAsEmpty()
        {
            Led25GridUtility.SetAsEmpty(this);
            PushValueAsEvent();
        }
        [ContextMenu("Set/Full Value")]
        public void SetAsFull()
        {
            Led25GridUtility.SetAsFull(this);
            PushValueAsEvent();
        }
        [ContextMenu("Set/Shield Value")]
        public void SetAsShield()
        {
            Led25GridUtility.SetAsLargeShield(this, 1);
            PushValueAsEvent();
        }
        [ContextMenu("Set/Shield Small Value")]
        public void SetAsShieldSmall()
        {
            Led25GridUtility.SetSmallShield(this, 1);
            PushValueAsEvent();
        }
        [ContextMenu("Set/Pixel Value")]
        public void SetSinglePixel()
        {
            Led25GridUtility.SetSinglePixel(this, 1);
            PushValueAsEvent();
        }

        [ContextMenu("Set/Random value")]
        public void SetAsRandomValue()
        {
            Led25GridUtility.SetAsRandomPercent(this, 1);
            PushValueAsEvent();
        }

        [ContextMenu("Set/Cross Little")]
        public void SetAsCrossLittle()
        {
            Led25GridUtility.SetAsSmallCross(this, 1, false);
            PushValueAsEvent();
        }

        [ContextMenu("Set/Cross Big")]
        public void SetAsCrossBig()
        {
            Led25GridUtility.SetAsLargeCross(this, 1, false);
            PushValueAsEvent();
        }

        [ContextMenu("Set/Cross Little Aim")]
        public void SetAsCrossLittleAim()
        {
            Led25GridUtility.SetAsSmallCross(this, 1, true);
            PushValueAsEvent();
        }

        [ContextMenu("Set/Push Cross Big Aim")]
        public void SetAsCrossBigAim()
        {
            Led25GridUtility.SetAsLargeCross(this, 1, true);
            PushValueAsEvent();
        }

        public override void GetLedAs0To9(int xLeftRight, int yDownTop, out int value)
        {
            ((I_Led25GridGetterLRDT)m_gridStateContainer).GetLedAs0To9(xLeftRight, yDownTop, out value);
        }

        public override void GetLedAs0To9(int indexTopDownArray25, out int value)
        {
            ((I_Led25GridGetterLRDT)m_gridStateContainer).GetLedAs0To9(indexTopDownArray25, out value);
        }

        public override void GetLedAsBool(int xLeftRight, int yDownTop, out bool isActive)
        {
            ((I_Led25GridGetterLRDT)m_gridStateContainer).GetLedAsBool(xLeftRight, yDownTop, out isActive);
        }

        public override void GetLedAsBool(int indexTopDownArray25, out bool value)
        {
            ((I_Led25GridGetterLRDT)m_gridStateContainer).GetLedAsBool(indexTopDownArray25, out value);
        }

        public override void GetLedAsPercent(int xLeftRight, int yDownTop, out float percent)
        {
            ((I_Led25GridGetterLRDT)m_gridStateContainer).GetLedAsPercent(xLeftRight, yDownTop, out percent);
        }

        public override void GetLedAsPercent(int indexTopDownArray25, out float value)
        {
            ((I_Led25GridGetterLRDT)m_gridStateContainer).GetLedAsPercent(indexTopDownArray25, out value);
        }

        public override void SetLedAs0To9(int xLeftRight, int yDownTop, int value)
        {
            ((I_Led25GridSetterLRDT)m_gridStateContainer).SetLedAs0To9(xLeftRight, yDownTop, value);
        }

        public override void SetLedAs0To9(int indexTopDownArray25, int value)
        {
            ((I_Led25GridSetterLRDT)m_gridStateContainer).SetLedAs0To9(indexTopDownArray25, value);

        }

        public override void SetLedAsBool(int xLeftRight, int yDownTop, bool isActive)
        {
            ((I_Led25GridSetterLRDT)m_gridStateContainer).SetLedAsBool(xLeftRight, yDownTop, isActive);
        }

        public override void SetLedAsBool(int indexTopDownArray25, bool value)
        {
            ((I_Led25GridSetterLRDT)m_gridStateContainer).SetLedAsBool(indexTopDownArray25, value);
        }

        public override void SetLedAsPercent(int xLeftRight, int yDownTop, float percent)
        {
            ((I_Led25GridSetterLRDT)m_gridStateContainer).SetLedAsPercent(xLeftRight, yDownTop, percent);
        }

        public override void SetLedAsPercent(int indexTopDownArray25, float value)
        {
            ((I_Led25GridSetterLRDT)m_gridStateContainer).SetLedAsPercent(indexTopDownArray25, value);
        }

        public override void CopyLedFromInterface(I_Led25GridGetterLRDT grid)
        {
            for (int i = 0; i < m_25; i++)
            {
                grid.GetLedAsPercent(i, out float value);
                SetLedAsPercent(i, value );
            }
            PushValueAsEvent();

        }

        public override void SetLedWithInteger25BitsRightLeft(int integer)
        {
            Led25GridUtility.SetLedWithInteger25BitsRightToLeft(this, integer);
            PushValueAsEvent();
        }

        public void SetWithBooleanRightToLeft(bool[] bytes)
        {
            Led25GridUtility.SetLedWith25BitsTopLeftToDownRight(this, bytes);
            PushValueAsEvent();
        }
        public void SetWithText(string text)
        {
            Led25GridUtility.SetWithText(this, text);
            PushValueAsEvent();
        }
    }
}
