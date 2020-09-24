/**
 * 팩토리 메소드
 * 
 * 객체를 생성하기 위한 인터페이스를 정의, 어떤 클래스의 인스턴스를 만들지는 파생클래스에서 결정
 * 팩토리 메소드는 객체 생성을 처리하며, 팩토리 메소드를 이용하여 객체를 생성하는 작업을
 * 파생클래스에 캡슐화
 * 
 * 기반 클래스에 있는 클라이언트 코드와 파생클래스에 있는 객체 생성 코드를 분리
 * 팩토리 메소드에서 파생클래스에 어떤 클래스를 만들지를 결정하게 함으로써 객체 생성을 캡슐화.
 * 
 **/
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            EnemyGenerator[] enemyGenerators = new EnemyGenerator[2];
            enemyGenerators[0] = new PatternAGenerator();
            enemyGenerators[1] = new PatternBGenerator();
            enemyGenerators[1].CreateEnemys();
            Console.ReadKey();
        }
    }
}
