using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. 템플릿 메서드가 실행할 구형화한 하위 알고리즘 클래스 생성 (A 유형)
            AbstractTemplate templateA = new ImplemnetationA();

            // 2. (A 유형) 템플릿 싈행
            templateA.TemplateMethod();

            // 3. 템플릿 메서드가 실행할 구형화한 하위 알고리즘 클래스 생성 (B 유형)
            AbstractTemplate templateB = new ImplemnetationB();

            // 4. (A 유형) 템플릿 싈행
            templateB.TemplateMethod();
        }
    }

    /// <summary>
    /// 템플릿 모체 추상 클래스 작성
    /// </summary>
    public abstract class AbstractTemplate
    {
        public void TemplateMethod()
        {
            // 상속하여 구현되면 실행될 메소드들
            Step1();
            Step2();

            // 훅 메소드 이용하여 중간 처리 내용 수행
            if(Hook())
            {
                Console.WriteLine("훅 들어왔다!");
                return;
            }

            Step3();
        }

        protected abstract void Step1(); // 템플릿 메소드 절차에서 수행될 단계-1
        protected abstract void Step2(); // 템플릿 메소드 절차에서 수행될 단계-2
        protected abstract void Step3(); // 템플릿 메소드 절차에서 수행될 단계-3

        // 다음 로직을 수행할지 말지 선택 분기용          
        protected virtual bool Hook() { return true; }
    }

    /// <summary>
    /// 템플릿 모체 상속받아 실제 동작들 구현 (A 유형)
    /// </summary>
    public class ImplemnetationA : AbstractTemplate
    {
        // Step1에서 수행할 동작
        protected override void Step1()
        {
            Console.WriteLine("ImplemnetationA - Step1 실행");
        }

        // Step2에서 수행할 동작
        protected override void Step2()
        {
            Console.WriteLine("ImplemnetationA - Step2 실행");
        }

        // Step3에서 수행할 동작
        protected override void Step3()
        {
            Console.WriteLine("ImplemnetationA - Step3 실행");
        }
    }

    /// <summary>
    /// 템플릿 모체 상속받아 실제 동작들 구현 (B 유형)
    /// </summary>
    public class ImplemnetationB : AbstractTemplate
    {
        // Step1에서 수행할 동작
        protected override void Step1()
        {
            Console.WriteLine("ImplemnetationB - Step1 실행");
        }

        // Step2에서 수행할 동작
        protected override void Step2()
        {
            Console.WriteLine("ImplemnetationB - Step2 실행");
        }

        // Step3에서 수행할 동작
        protected override void Step3()
        {
            Console.WriteLine("ImplemnetationB - Step3 실행");
        }

        // 훅 메소드 내용 구현
        protected override bool Hook()
        {
            Console.WriteLine("훅 사용 안할꺼야!");
            return false;
        }
    }

}
