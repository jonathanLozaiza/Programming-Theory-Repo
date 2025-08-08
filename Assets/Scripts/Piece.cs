using System;
using UnityEngine;

public class Piece : MonoBehaviour
{
    private float m_forceMin = 5.0f;
    public float forceMin
    {
        get { return m_forceMin; }
        set {
            if(value >= 1.0f && value < m_forceMax)
            {
                m_forceMin = value;
            }
            else
            {
                m_forceMin = m_forceMax - 1.0f;
            }
        }
    }
    private float m_forceMax = 10.0f;
    public float forceMax
    {
        get { return m_forceMax; }
        set
        {
            if (value > m_forceMin && value > 0.0f)
            {
                m_forceMax = value;
            }
            else
            {
                m_forceMax = m_forceMin + 1.0f;
            }
        }
    }
    protected Rigidbody rb;

    protected void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public virtual void ApplyForce()
    {
        float randomForce = GetForce();
        rb.AddForce(Vector3.forward * randomForce, ForceMode.Impulse);
    }

    public void ApplyForce(Vector3 forceDirection)
    {
        float randomForce = GetForce();
        rb.AddForce(forceDirection * randomForce, ForceMode.Impulse);
    }

    public float GetForce()
    {
        return UnityEngine.Random.Range(forceMin, forceMax);
    }
    
}
