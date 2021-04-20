﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class Program
    {
        // var 키워드는 지역변수로만 사용 가능
        static void Main(string[] args)
        {
            // keyword
            // int as;

            // context keyword
            var name = "함기훈";

            // 식별자 Identifier
            int alpha;
            int Alpha;
            // int break;
            // int 2abc;
            // int has space;
            // int 😘;
            int 한글숫자;

            // inline comment
            /*
             * comment
             */

            // 출력
            Console.Write("이건 안개행");
            Console.Write(" 입니당\n");
            Console.Write("");
            Console.WriteLine("이건 개행");

            // Integer
            Console.WriteLine(53 + 272 - 123);
            Console.WriteLine(53 * 3 - 3);
            Console.WriteLine(14 / 2); // 7
            Console.WriteLine(14 / 3); // 4
            Console.WriteLine(14 % 3); // 2

            // Real Number
            Console.WriteLine();

            Console.WriteLine(0);
            Console.WriteLine(0.0);
            Console.WriteLine(14.0 /  2.0); // 7
            Console.WriteLine(14.0 /  3.0); // 4.6666667
            // Console.WriteLine(14.0 /% 3.0);
            Console.WriteLine(14 / 3); // 4
            Console.WriteLine(14.0 / 3); // 4.6666667
            Console.WriteLine(14 / 3.0); // 4.6666667

            // Character
            Console.WriteLine('A'); // 문자

            // String
            Console.WriteLine("A"); // 문자열

            // Escape Character
            Console.WriteLine("\t 탭 \\ 역슬래시 \n 개행 \" ");
            Console.WriteLine("미\t림여자정보과학고");
            Console.WriteLine("미림\t여자정보과학고");
            Console.WriteLine("미림여\t자정보과학고");
            Console.WriteLine("미림여자\t정보과학고");
            Console.WriteLine("미림여자정\t보과학고");
            Console.WriteLine("미림여자정보\t과학고");
            Console.WriteLine("미림여자정보과\t학고");
            Console.WriteLine("미림여자정보과학\t고");
        }
    }
}
