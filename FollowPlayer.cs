using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player; //장애물 차량 등 모두 게임 오브젝트 클래스이다. 이런 오브젝트를 바로 가져올 수 있다. 변수명은 player로 하겠다.
    //유니티 내에서 가져왓으므로 이걸 private해주면 인식 못함.
    private Vector3 offset = new Vector3(0, 5, -7); //Vector3 유형의 변수를 만든것.

    // Start is called before the first frame update
    void Start()
    {
       
}

    // Update is called once per frame
    void LateUpdate()
    {
        //카메라와 차량이 같이(어떨땐 차량이 먼저, 어떨떈 카메라가 먼저 움직임)움직이지 못해 부드럽지 못하다. 그래서 LateUpdate를 추가해야함.
        //Updata메서드를 호출 후 업데이트 된다. 차량이 움직인 후 카메라가 업데이트 된다는 것.
        //GameObjuect를 이용해 오브젝트의 transform컴포넌트를 가져올 수 있다.
        //카메라의 x,y,z좌표를 가져올 수 있다. player의 x,y,z또한 가져올 수 있다.
        //Offset(지정?하는 느낌의 뜻) the camera behind the player by adding to the player's position
        transform.position = player.transform.position + offset; //플레이어 위치는 Vector3로 주어지기 때문에 new(키워드) Vector3해 새로 만들어줘야함. 
    }
}
