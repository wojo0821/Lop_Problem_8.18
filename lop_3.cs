using System;

class lop3
{
    public static void Main3()
    {
        while (true)
        {
            Console.Write("금액을 입력하세요(10의 배수로만): ");
            string? price_str = Console.ReadLine();

            if (int.TryParse(price_str, out int price))
            {
                if (price < 0)
                {
                    Console.WriteLine("음수 입력은 지원하지 않습니다.");
                    continue;
                }
                if (price % 10 != 0)
                {
                    Console.WriteLine("10의 배수로만 입력해주세요.");
                    continue;
                }

                int count_500 = 0;
                int count_100 = 0;
                int count_50 = 0;
                int count_10 = 0;

                for (int i = 0; i < price; i += 500)
                {
                    count_500++;
                }
                price -= count_500 * 500;
                for (int i = 0; i < price; i += 100)
                {
                    count_100++;
                }
                price -= count_100 * 100;
                for (int i = 0; i < price; i += 50)
                {
                    count_50++;
                }
                price -= count_50 * 50;
                for (int i = 0; i < price; i += 10)
                {
                    count_10++;
                }

                Console.WriteLine("500원: {0}개", count_500);
                Console.WriteLine("100원: {0}개", count_100);
                Console.WriteLine("50원: {0}개", count_50);
                Console.WriteLine("10원: {0}개", count_10);
                Console.WriteLine("최소 동전 수: {0}개", count_500 + count_100 + count_50 + count_10);
                break;
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");
                continue;
            }
        }
    }
}