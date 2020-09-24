/**
 * 이터레이터
 * 
 * 객체 집합의 내용을 노출시키지 않고 집합의 원소들을 모든 항목에 순차적으로 접근할 수 
 * 있는 방법을 제공
 * 객체 내부의 표현 방식을 알 필요 없이 집합의 각 원소들에 접근하고 싶을때 사용
 * 서로 다른구조의 객체 집합을 동일한 방식으로 순차 접근하고 싶을때 사용
 * 
 **/
using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";

            ConcreteIterator i = new ConcreteIterator(a);

            Console.WriteLine("Iterating over collection:");

            object item = i.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }
            Console.ReadKey();
        }
    }
}
