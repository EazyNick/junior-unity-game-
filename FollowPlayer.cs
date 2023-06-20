using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player; //��ֹ� ���� �� ��� ���� ������Ʈ Ŭ�����̴�. �̷� ������Ʈ�� �ٷ� ������ �� �ִ�. �������� player�� �ϰڴ�.
    //����Ƽ ������ ���������Ƿ� �̰� private���ָ� �ν� ����.
    private Vector3 offset = new Vector3(0, 5, -7); //Vector3 ������ ������ �����.

    // Start is called before the first frame update
    void Start()
    {
       
}

    // Update is called once per frame
    void LateUpdate()
    {
        //ī�޶�� ������ ����(��� ������ ����, ��� ī�޶� ���� ������)�������� ���� �ε巴�� ���ϴ�. �׷��� LateUpdate�� �߰��ؾ���.
        //Updata�޼��带 ȣ�� �� ������Ʈ �ȴ�. ������ ������ �� ī�޶� ������Ʈ �ȴٴ� ��.
        //GameObjuect�� �̿��� ������Ʈ�� transform������Ʈ�� ������ �� �ִ�.
        //ī�޶��� x,y,z��ǥ�� ������ �� �ִ�. player�� x,y,z���� ������ �� �ִ�.
        //Offset(����?�ϴ� ������ ��) the camera behind the player by adding to the player's position
        transform.position = player.transform.position + offset; //�÷��̾� ��ġ�� Vector3�� �־����� ������ new(Ű����) Vector3�� ���� ����������. 
    }
}
