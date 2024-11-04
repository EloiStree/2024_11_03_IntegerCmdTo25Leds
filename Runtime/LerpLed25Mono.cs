using UnityEngine;
using UnityEngine.Events;


namespace Eloi.Led25
{
    public class LerpLed25Mono : MonoBehaviour
    {
        public AbstractLed25GridLRDTMono m_toMirror;
        public AbstractLed25GridLRDTMono m_toChange;
        public float m_lerpSpeed = 1;
        public UnityEvent m_onUpdate;

        public void Update()
        {
            if (m_toMirror == null || m_toChange == null)
                return;

            for (int i = 0; i < 25; i++)
            {
                m_toMirror.GetLedAsPercent(i, out float toMirroValue);
                m_toChange.GetLedAsPercent(i, out float currentValue);
                currentValue = Mathf.Lerp(currentValue, toMirroValue, m_lerpSpeed * Time.deltaTime);
                m_toChange.SetLedAsPercent(i, currentValue);
            }
            m_onUpdate.Invoke();
        }

    }
}
