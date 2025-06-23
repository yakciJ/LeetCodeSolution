namespace LeetCodeSolution
{
    class Program
    {
        // 23/6/2025 | 2081. Sum of k-Mirror Numbers

        public static void Main()
        {
            Console.WriteLine(Solution(3, 7));
        }
        // Số đầu gồm 9 số, vì không có số 0 đứng đầu, x số giữa có 10 số, số cuối phải == số đầu nên cũng có 9 số.
        // nói chung là số số 0 == số cuối, số 1 = số cuối - 1, số 2 = số cuối - 2,... cho đến số giữa. Và phải thử hết toàn bộ trường hợp.
        // Chỉ cần sinh số ở nửa đàu, xong sau đó lộn ngược lại ghép vào nửa sau, nếu số lẻ thì xóa bớt số đầu của nửa sau sau khi lật, còn chẵn thì giữ nguyên, mỗi lần tăng số thì mình chỉ cần tăng độ dài của nửa đầu là được.
        // Ví dụ: số tổng có 5 chữ số, thì chỉ cần gen 3 số đầu là số từ 100 đến 999, sau đó lộn ngược lại là được. Chạy hết từ 100 đến 999.
        // Ví dụ 8 số: gen 4 số đầu từ 1000 đến 9999, cũng là chạy bằng sạch, sau đó lộn ngược lại với từng số, xong check xem có palindrome với hệ số k k, nếu có thì sum += số và n++.
        public static long Solution(int k, int n)
        {
            long sum = 0;
            long count = 0;
            long numLength = 1;
            string ConvertToBaseK(long number, int k)
            {
                string numK = "";
                while (number > 0)
                {
                    long x = number % k;
                    numK = x + numK;
                    number /= k;
                }
                return numK;
            }
            bool IsPalindrome(string s)
            {
                for (int i = 0; i < s.Length / 2; i++)
                {
                    if (s[i] != s[s.Length - 1 - i])
                    {
                        return false;
                    }
                }
                return true;
            }
            while (true)
            {
                long x = (long)Math.Ceiling((double)numLength / 2);
                long start = (long)Math.Pow(10, x - 1);
                long end = (long)Math.Pow(10, x) - 1;
                for (long i = start; i <= end; i++)
                {
                    // lộn số lại, sau đó chuyển qua hệ số k, check xem có palindrome không, nếu có n++ và sum +=
                    string temp = i.ToString();
                    if (numLength % 2 == 0)
                    {
                        temp += new string([.. temp.Reverse()]);
                    }
                    else
                    {
                        string temp2 = new string([.. temp.Reverse()]);
                        temp += temp2.Substring(1);
                    }
                    long num = long.Parse(temp);
                    if (IsPalindrome(ConvertToBaseK(num, k)))
                    {
                        sum += num;
                        count++;
                        if (count == n)    // vừa đủ, trả về luôn
                            return sum;
                    }
                }
                numLength++;
            }
        }
    }
}

