using System;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;

namespace Scrips
{
    public class EnemyDamage : MonoBehaviour
    {
        public UnityEvent OnEnemyDestroy;


        [SerializeField] private MeshRenderer _meshRenderer;
        [SerializeField] private int _maxHealth = 10;
        private int _health;

        private void Start()
        {
            _health = _maxHealth;
        }

        private void OnMouseDown()
        {
            _health-=Player.instance.danage;
            if (_health <= 0)
            {
                ChangeColor();
                _health = _maxHealth;
                OnEnemyDestroy.Invoke();
                
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
