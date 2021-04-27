using System;
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

            // 문자열 연결 연산자
            // concat concatenate operator
            // concatenation operator
            Console.WriteLine("ABC" + "EFG");
            Console.WriteLine('A' + 'E'); // 134
            Console.WriteLine("ABC" + 'E'); // ABCE

            Console.WriteLine("ABC"[2]);

            //comparison operator
            Console.WriteLine(52 == 163);
            Console.WriteLine(52 != 163);
            Console.WriteLine(52 > 163); // gt
            Console.WriteLine(52 < 163); // lt
            Console.WriteLine(52 >= 163);
            Console.WriteLine(52 <= 163);

            // Logic operator
            Console.WriteLine(!(true));
            Console.WriteLine(true || false);
            Console.WriteLine(true && false);

            // 단항연산자 - unary operator
            int i=0;
            i++;
            // 이항연산자 - binary operator
            i = 1 + 2;
            // 삼항연산자 - ternary operator
            int j = 0; 
            j = (1>3) ? 0 : 1;

            // Console.WriteLine(3 < i < 8);
            Console.WriteLine(3 < i && i < 8);
            Console.WriteLine(3 > i || i > 8);
            Console.WriteLine(i < 2 || 8 < i);

            int a = 21468410;
            int b = 10000000;
            Console.WriteLine((long)a + b);

            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(double.MaxValue);

            Console.WriteLine( - int.MaxValue);
            // Console.WriteLine( - int.MinValue);

            Console.WriteLine(3L);
            Console.WriteLine(3l);

            Console.WriteLine(3);
            Console.WriteLine(3.0);
            char c = 'a';
            Console.WriteLine(c);

            // sizeof(자료형)
            Console.WriteLine("int : " + sizeof(int));
            Console.WriteLine("long : " + sizeof(long));
            Console.WriteLine("float : " + sizeof(float));
            Console.WriteLine("double : " + sizeof(double));
            Console.WriteLine("char : " + sizeof(char));

            bool IsLive = true;

            var a1 = (int)10.0;
            var b1 = (float)10;
            var c1 = (double)10;

            long longNumber = 2147483637L + 2100000000L;
            int intNumber = (int)longNumber;
            Console.WriteLine(intNumber);

            long longNumber2 = 52773;
            int intNumber2 = (int)longNumber2;
            Console.WriteLine(intNumber2);

            Console.WriteLine("int, long, float, double MaxValue");
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(double.MaxValue);

            Console.WriteLine("문자열 숫자로 변환");
            Console.WriteLine(int.Parse("52"));
            Console.WriteLine(long.Parse("412"));
            Console.WriteLine(float.Parse("52.273"));
            Console.WriteLine(double.Parse("22.32"));
            Console.WriteLine(int.Parse("52").GetType());
            Console.WriteLine(long.Parse("412").GetType());
            Console.WriteLine(float.Parse("52.273").GetType());
            Console.WriteLine(double.Parse("22.32").GetType());

            Console.WriteLine(int.Parse("52.273"));
            Console.WriteLine(int.Parse("abc"));
            Console.WriteLine(int.Parse("육십삼"));
            Console.WriteLine(int.Parse("Seven"));

            (10).ToString();
            (52.292).ToString();

            double numberToString = 52.1985;
            Console.WriteLine(numberToString.ToString("0.0"));
            Console.WriteLine(numberToString.ToString("0.00"));
            Console.WriteLine(numberToString.ToString("0.000"));
            Console.WriteLine(numberToString.ToString("0.0000"));

            // 숫자와 문자열 덧셈
            Console.WriteLine(52 + 273);
            Console.WriteLine("52" + 273);
            Console.WriteLine(52 + "273");
            Console.WriteLine("52" + "273");
            Console.WriteLine(52 + 2 + 273);
            Console.WriteLine(52 + "2" + 273);
            Console.WriteLine("52" + 2 + 273);
            Console.WriteLine(52 + 2 + "273");

            int number = 52273;
            string outputA = number + "";

            char character = 'a';
            string outputB = character + "";
            Console.WriteLine(outputB);

            Console.WriteLine(bool.Parse("True"));
            Console.WriteLine(bool.Parse("true"));
            Console.WriteLine(bool.Parse("TRUE"));
            Console.WriteLine(bool.Parse("truE"));
            Console.WriteLine(bool.Parse("TrUe"));

            int outputInt = int.MinValue;
            Console.WriteLine(-(long)outputInt);
            Console.WriteLine(-(-2147483618));
        }
    }
}
