using UnityEngine;

public class Mover : AnimationComponent
{
    private void Update()
    {
        transform.position += transform.up * _speed * Time.deltaTime;
    }
}
