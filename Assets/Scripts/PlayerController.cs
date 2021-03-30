using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 3.0f;
    public int maxHealth = 5;
    public int currentHealth;
    public float maxStamina = 1.0f;
    public float currentStamina;
    public float maxStarvationLevel = 10f;
    public float starvationLevel;
    public float timeInvincible = 1.5f;

    public UIHUDBars healthBar;
    public UIHUDBars energyBar;
    public UIHUDBars starvationBar;

    bool isInvincible;
    float invincibleTimer;

    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;

    Animator animator;
    Vector2 lookDirection = new Vector2(1, 0);

    Scene scene;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();

        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        currentStamina = 0.3f;
        energyBar.SetMaxStamina(maxStamina);
        energyBar.SetStamina(currentStamina);

        starvationLevel = 1f;
        maxStarvationLevel = 5f;
        starvationBar.SetMaxStarvationLevel(maxStarvationLevel);
        starvationBar.SetStarvationLevel(starvationLevel);

        animator = GetComponent<Animator>();

        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        Vector2 move = new Vector2(horizontal, vertical);
        if (!Mathf.Approximately(move.x, 0.0f) || !Mathf.Approximately(move.y, 0.0f))
        {
            lookDirection.Set(move.x, move.y);
            lookDirection.Normalize();
        }

        animator.SetFloat("Look X", lookDirection.x);
        animator.SetFloat("Look Y", lookDirection.y);
        animator.SetFloat("Speed", move.magnitude);

        if (isInvincible)
        {
            invincibleTimer -= Time.deltaTime;
            if (invincibleTimer < 0)
            {
                isInvincible = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape) && scene.buildIndex != 0)
        {
            SceneManager.LoadScene(0);
        }
    }

    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;

        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;

        rigidbody2d.MovePosition(position);
    }

    public void ChangeHealth(int amount)
    {
        if (amount < 0)
        {
            if (isInvincible == true)
            {
                return;
            }

            isInvincible = true;
            invincibleTimer = timeInvincible;
        }

        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        healthBar.SetHealth(currentHealth);
    }


    public void ChangeStamina(int amount)
    {

        currentStamina = Mathf.Clamp(currentStamina + amount, 0, maxStamina);
        energyBar.SetStamina(currentStamina);
    }

    public void ChangeStarvationLevel(float amount)
    {
        starvationLevel = Mathf.Clamp(starvationLevel + amount, 0, maxStarvationLevel);
        starvationBar.SetStarvationLevel(starvationLevel);
    }
}
