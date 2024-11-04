using UnityEngine;


namespace Eloi.Led25
{
    public abstract class AbstractLed25GridLRDTMono : MonoBehaviour, I_Led25GridGetSetLRDT
    {
        public abstract void GetLedAs0To9(int xLeftRight, int yDownTop, out int value);
        public abstract void GetLedAs0To9(int indexTopDownArray25, out int value);
        public abstract void GetLedAsBool(int xLeftRight, int yDownTop, out bool isActive);
        public abstract void GetLedAsBool(int indexTopDownArray25, out bool value);
        public abstract void GetLedAsPercent(int xLeftRight, int yDownTop, out float percent);
        public abstract void GetLedAsPercent(int indexTopDownArray25, out float value);
        public abstract void SetLedAs0To9(int xLeftRight, int yDownTop, int value);
        public abstract void SetLedAs0To9(int indexTopDownArray25, int value);
        public abstract void SetLedAsBool(int xLeftRight, int yDownTop, bool isActive);
        public abstract void SetLedAsBool(int indexTopDownArray25, bool value);
        public abstract void SetLedAsPercent(int xLeftRight, int yDownTop, float percent);
        public abstract void SetLedAsPercent(int indexTopDownArray25, float value);
        public abstract void CopyLedFromInterface(I_Led25GridGetterLRDT grid);
        public abstract void SetLedWithInteger25BitsRightLeft(int integer);
    }
}
