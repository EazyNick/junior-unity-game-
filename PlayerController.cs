//The .NET Core SDK cannot be located: A valid dotnet installation could not be found. .NET Core debugging will not be enabled. Make sure the .NET Core SDK is installed and is on the path.
//.NET Core SDK를 안깔면 디버깅 안된다는거. 디버깅 안할꺼니 안깔아! 
//일단 visual studio로 진행.
//코드의 가독성이 좋아야 제3자가 쉽게 개발에 참여할 수 있으므로 쉽게 개발

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour //MonoBehaviour이라는 부모함수에게 상속받음. Start, Update다 MonoBehaviour의 메서드들
    //Publice은 다른곳에서 이 클래스를 엑세스하고, 참조하고 사용할 수 있다는 의미이다. unity에서 Inspector에 나타남.
{
    private float speed = 5.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    //float은 소수점이 포함된 숫자를 만든다고 알리는 키워드이다. 컴퓨터가 인식을 못해 0.5f, 뒤에 f를 붙여 float이라고 알림. speed는 클래스 안에 있으므로 멤버 변수라고 불림
    //public은 클래스 외부에서도 사용가능한 변수이다. private(액세스 한정자, public도)를 이용해 speed변수에 대한 엑세스 권한 수준을 표시할 수 있다. 이 클래스 내에서만 동작 한다는 것.
    //void Start, Update함수는 본질적으로 private이므로 입력해줄 필요가 없다. 

    // Start is called before the first frame update, 첫 시작시 start 메서드 호출.
    void Start()
    {
        
    }

    // Update is called once per frame, 1프레임마다 업데이트됨. 보통 50~60프레임임,
    void Update()
    {
        //This is Where we get player input
        horizontalInput = Input.GetAxis("Horizontal"); //문자열은 ""해서 사용
        forwardInput = Input.GetAxis("Vertical");                                             
        //Input매니저 클라스에서, 메서드 GetAxis를 사용해 해당축에서 왼, 오른쪽 눌렀을때 값을 알려줌. 이때 사용할 축 이름은 Horizontal이다.

        //transform.Translate(0, 0, 1) 아무 키도 안눌러도 z축방향으로 쭉감, Vector3.forward = (0, 0, 1)을 담고있음
        // Moves the car forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); //유니티에 Edit - Preferences - External Tools - Editor를 비주얼스튜디오로 해줘야함.
        
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput); 좌우만 이동.

        // Rotate the car based on horizontal input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput); //좌우 회전(자연스러움)


        //이제는 프레임마다하면 기기마다 차이가 생기므로 초당 얼마만큼 가게 설정. 초당 1유닛(deltatime기본값)씩 감. forward에 *(곱하기) time.deltatime * 20 초당 20미터씩 간다는 것.
        //translate라는 클래스를 불러와 뒤에.붙이면 그 클래스안의 메서드를 불러올 수 있음. 메서드니 대문자T로됨, 60프레임이니 초당 50~60유닛씩 움직임.
    }
}