using UnityEngine;

public class SphericalPiece : Piece
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Start();
        forceMin = 10.0f;
        forceMax = 20.0f;
    }

    public void OnMouseDown()
    {
        ApplyForce();
    }

    public override void ApplyForce()
    {
        float randomForce = GetForce();
        rb.AddForce(Vector3.up * randomForce, ForceMode.Impulse);
    }
}
