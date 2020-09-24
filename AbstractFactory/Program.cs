/**
 * 추상팩토리
 * 객체를 구성하는 부분을 추상화하여 여러 서브클래스가 상속/구현 받아서 객체를 구성
 * 객체를 구성하는 클래스들의 공정을 추상화
 * 
 * 장점: 객체 생성 과정에 일관성이 있다.
 * 단점: 객체의 구현 내용이 추가 되면 추상클래스까지 수정해야합낟.
 * 
 * */
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstactFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.Run();

            AbstactFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run();

            Console.ReadKey();
        }
    }
}
