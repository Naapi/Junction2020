using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class shootBullet : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Transform bullet;

    public void OnPointerClick(PointerEventData eventData)
    {
        // TODO: name of the object will have to be changed after loading catank model
        GameObject player = GameObject.Find("Placeholder Player");
        // TODO: offet will have to be modified when actal catank model is loaded
        Vector3 offset = Vector3.zero;
        offset.y = player.transform.lossyScale.y;
        //offset.x = player.transform.lossyScale.x / 2;
        //offset.z = player.transform.lossyScale.z / 2;
        Transform bulletTransform = Instantiate(bullet, player.transform.position + offset, Quaternion.identity);

        bulletTransform.GetComponent<Bullet>().Setup(player.transform.rotation);
    }
}
