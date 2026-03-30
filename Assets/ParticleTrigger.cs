using UnityEngine;

public class ParticleTrigger : MonoBehaviour
{

    private ParticleSystem[] targetParticleSystem; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targetParticleSystem = GetComponentsInChildren<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TriggerExplosion()
    {
        foreach(ParticleSystem ps in targetParticleSystem)
        {
            ps.Play();
        }
    }
}
