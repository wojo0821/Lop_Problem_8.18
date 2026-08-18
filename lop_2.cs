using System;

class lop2
{
    public static void Main2()
    {
        while (true)
        {
            Console.Write("입력할 숫자 수: ");
            string? count_num_str = Console.ReadLine();
            Console.Write("숫자를 입력하세요(띄어쓰기로 구분): ");
            string? num_str = Console.ReadLine();

            if (num_str == null || count_num_str == null)
            {
                Console.WriteLine("잘못된 입력입니다.");
                continue;
            }

            if (int.TryParse(count_num_str, out int count_num))
            {
                string[] num_split = num_str.Split(' ');
                int[] nums = new int[count_num];
                int count = 0;
                int maxcount = 0;
                bool check = true;

                if (num_split.Length != count_num)
                {
                    Console.WriteLine("입력한 숫자의 수가 맞지 않습니다.");
                    continue;
                }
                for (int i = 0; i < count_num; i++)
                {
                    if (!int.TryParse(num_split[i], out nums[i]))
                    {
                        Console.WriteLine("잘못된 입력입니다.");
                        check = false;
                        break;
                    }
                }
                if (!check)
                {
                    continue;
                }

                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] + 1 == nums[i + 1])
                    {
                        count++;
                        if (maxcount < count)
                        {
                            maxcount = count;
                        }
                    }
                    else
                    {
                        count = 0;
                    }
                }
                Console.WriteLine("가장 긴 연속된 수의 길이: {0}", maxcount + 1);
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