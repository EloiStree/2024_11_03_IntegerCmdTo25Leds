using System;
using UnityEngine;
using UnityEngine.Events;


namespace Eloi.Led25
{
    public class Led25PixelsToJoystick : MonoBehaviour {
        
        public AbstractLed25GridLRDTMono m_led25Grid;
        
        [Range(-1f,1f)]
        public float m_xLeftRight;
        [Range(-1f, 1f)]
        public float m_yDownTop;

        public UnityEvent<float> m_onLeftRight;
        public UnityEvent<float> m_onDownTop;

        [ContextMenu("Compute And Push Value")]
        public void ComputeAndPushValue() {
            Led25GridUtility.GetDefaultPixelDirectionAsBool(m_led25Grid,out m_xLeftRight, out m_yDownTop);
        
            m_onLeftRight.Invoke(m_xLeftRight);
            m_onDownTop.Invoke(m_yDownTop);
        }



    }
}
