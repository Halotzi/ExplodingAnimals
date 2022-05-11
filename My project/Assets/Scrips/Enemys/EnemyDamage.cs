using System;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;

namespace Scrips
{
    public class EnemyDamage : MonoBehaviour
    {
        public UnityEvent OnEnemyDestroy;


        [SerializeField] private SkinnedMeshRenderer _meshRenderer;
        [SerializeField] private int _maxHealth = 10;
        Animator Anim;

        public AudioSource Ouch;
        private int _health;

        private void Start()
        {
            Anim = GetComponent<Animator>();
            _health = _maxHealth;
        }
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _health -= Player.instance.danage;
                Anim.SetTrigger("Hit");
                Ouch.Play();
                if (_health <= 0)
                {
                    ChangeColor();
                    _maxHealth += 2;
                    _health = _maxHealth;
                    OnEnemyDestroy.Invoke();

                }
            }
        }

        private void ChangeColor()
        {
            float r = Random.Range(0.0f, 1.0f);
            float g = Random.Range(0.0f, 1.0f);
            float b = Random.Range(0.0f, 1.0f);
            _meshRenderer.material.color = new Color(r,g,b, 1);
            Debug.Log(r + "" + g + "" + b);
        }
    }
}
