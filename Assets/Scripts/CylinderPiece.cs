using UnityEngine;

public class CylinderPiece : Piece
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Start();
        forceMin = 60.0f;
        forceMax = 100.0f;
    }

    private void OnMouseDown()
    {
        ApplyForce();
    }

    // Update is called once per frame
    public override void ApplyForce()
    {
        float randomForce = GetForce();
        rb.AddForce(Vector3.left * randomForce, ForceMode.Impulse);
    }
}
