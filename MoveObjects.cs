using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjects : MonoBehaviour
{
    [SerializeField] string _tagTarget;
    [SerializeField] float count;
    [SerializeField] float distance;
    [SerializeField] bool changeY;
    [SerializeField] float minY;
    [SerializeField] float maxY;


    private void Awake()
    {
        if (!changeY) return;
        
            var _objectsToChangeY = GameObject.FindGameObjectsWithTag(_tagTarget);

            foreach (var _obj in _objectsToChangeY)
            {
                Vector2 _pos = _obj.transform.position;

                _pos.y = Random.Range(minY, maxY);

                _obj.transform.position = _pos;
            }
        
    }
    private void OnTriggerExit2D(Collider2D _other)
    {
        if (_other.CompareTag(_tagTarget)) {

            Vector2 _pos = _other.transform.position;

            _pos.x += count * distance;

            if(changeY) 
                _pos.y = Random.Range(minY, maxY);

            _other.transform.position = _pos;

            }
 
        }

    }

