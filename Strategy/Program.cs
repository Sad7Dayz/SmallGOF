/**
 * 전략
 * 알고리즘 군을 정의하고 각각을 캡슐화하여 교환하며 사용할 수 있도록 만드는 패턴
 * 알고리즘을 사용하는 클라이언트와 독립적으로 알고리즘의 변경이 가능
 * 결과를 만드는 메소드는 동일하나 그 목적을 달성하는 방법이 여러가지가 존재 할 경우 사용
 * 
 **/
using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context;

            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();

            Console.ReadKey();
        }
    }
}
