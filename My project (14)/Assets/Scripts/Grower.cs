using UnityEngine;

public class Grower : AnimationComponent
{
    private void Update()
    {
        transform.localScale += Vector3.one * _speed * Time.deltaTime;
    }
}
