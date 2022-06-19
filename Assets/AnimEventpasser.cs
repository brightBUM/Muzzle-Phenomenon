using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimEventpasser : MonoBehaviour
{
    [SerializeField] Grunt grunt;
    // Start is called before the first frame update
    void Start()
    {
        grunt = GetComponentInParent<Grunt>();
    }

    public void ThrowSphere()
    {
        grunt.AimAndThrow();
    }
}
