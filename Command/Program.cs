/**
 * 커맨드
 * 특정객체에 대한 특정 작업 요청을 캡슐화
 * 사용자가 보낸 요청을 나중에 이용 할 수 있도록 메서드 이름, 매개변수등 요청에 필요한 정보를 저장 또는
 * 로깅, 취소할 수 있게 하는 패턴
 * 요청과 수행을 분리
 * 커맨드 객체는 수신자 객체를 가지고 있으며, 수신자의 메서드를 호출하고, 이에 수신자는
 * 자신에게 정의돈 메소드를 수행
 * 
 **/ 

using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Receiver receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);

            Invoker invoker = new Invoker();
            invoker.SetCommand(command);
            invoker.ExecuteCommand();

            Console.ReadKey();

        }
    }
}
