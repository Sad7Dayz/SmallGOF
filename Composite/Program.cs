/**
 *https://codepump.tistory.com/37?category=672020 
 * 컴포지트
 * 객체들의 관계를 트리 구조로 구성하여 부분-전체 계층을 표현하는 패턴
 * 사용자가 단일 객체와 복합 객체 모두 동일하게 처리 함
 * 
 * 사용방법
 * 객체의 구성 및 상하위 체계를 파악
 * 파악된 객체들을 트리 구조로 설계
 * 객체와 복합객체는 공통으로 사용할 수 있는 메소드가 정의된 인터페이스/추상클래스를 구현/싱속
 * 
 **/
using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite comp = new Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));

            root.Add(comp);
            root.Add(new Leaf("Leaf C"));

            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);

            root.Display(1);

            Console.ReadKey();
        }
    }
}
