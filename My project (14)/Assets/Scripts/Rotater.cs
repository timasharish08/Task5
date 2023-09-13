using UnityEngine;

public class Rotater : AnimationComponent
{
    private void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0 , transform.rotation.eulerAngles.z + _speed * Time.deltaTime);
    }
}
