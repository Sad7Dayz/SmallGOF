/**
 * 데코레이터 패턴
 * 상황 및 용도에 따라 객체 필요한 요소들을 동적으로 추가한다.
 * 기능 확장이 필요할 경우 클래스를 상속하는 대신 유연하게 사용할 수 있다.
 * 하나의 객체를 여러 개의 데코레이터를 추가 할 수 있다.
 * 
 * 장점
 * 기존코드를 수정하지 않고도 확장 할수 있다.
 * 단점
 * 클래스의 종류가 많이지고 객체를 파악하기 어려워진다.
 * 
 * 
 **/
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            d1.SetComponent(c);
            d2.SetComponent(d1);

            d2.Operation();

            Console.ReadKey();
        }
    }
}
