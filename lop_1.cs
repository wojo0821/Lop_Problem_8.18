using System;

class lop1
{
    public static void Main1()
    {
        while (true)
        {
            Console.Write("숫자를 입력하세요: ");
            string? num_str = Console.ReadLine(); // null아님을 "?"로 보장해서 경고를 무시

            if (int.TryParse(num_str, out int num))
            {
                if (num < 0)
                {
                    Console.WriteLine("음수 입력은 지원하지 않습니다.");
                    continue;
                }
                char[] num_char = num_str.ToCharArray();
                int Before_num = num;
                string After_num_str = "";
                int After_num;

                for (int i = num_char.Length - 1; i >= 0; i--)
                {
                    string str = num_char[i].ToString();
                    After_num_str += str;
                }
                After_num = int.Parse(After_num_str);
                Console.WriteLine("{0}의 역순은 {1}입니다.", Before_num, After_num);
                if (Before_num == After_num)
                {
                    Console.WriteLine("팰린드름 여부: O");
                }
                else
                {
                    Console.WriteLine("팰린드름 여부: X");
                }
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