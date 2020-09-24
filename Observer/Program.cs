/**
 * 옵저버
 * 객체의 상황 변화를 관찰하는 관찰자들의 목록을 객체에 등록하여 상태
 * 변화가 있을 때 마다 메소드를 통해 객체가 직접 관찰자들에 통지하는 패턴
 * 
 * 한 객체의 상태가 바뀌면 그 객체에 의존하는 다른 객체들한데 연락이 자동으로 전달
 * 
 * 일대다 의존성을 정의
 * 
 * 분산 이벤트 핸들링 시스테 구현에 사용
 * 
 **/

using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject s = new ConcreteSubject();
            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));

            s.SubjectState = "ABC";
            s.Notify();

            Console.ReadKey();
        }
    }
}
