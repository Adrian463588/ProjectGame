using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    [SerializeField] private float damage;
    private float cooldownTimer = Mathf.Infinity;

    private bool PlayerInSight;

    // Start is called before the first frame update
    void Start()
    {
        cooldownTimer += Time.deltaTime;

        if (cooldownTimer > attackCooldown)
        {
            //attack
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
