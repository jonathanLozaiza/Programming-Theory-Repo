using UnityEngine;

public class SquarePiece : Piece
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Start();
        forceMin = 20.0f;
        forceMax = 40.0f;
    }

    private void OnMouseDown()
    {
        ApplyForce();
    }

    // Update is called once per frame
    public override void ApplyForce()
    {
        float randomForce = GetForce();
        Debug.Log(randomForce);
        rb.AddForce(Vector3.forward * randomForce, ForceMode.Impulse);
    }
}
