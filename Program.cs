Console.Clear();


            int first, second, third;

            
            Console.WriteLine("Введите первое число : ");
            first = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число : ");
            second = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число : ");
            third = int.Parse(Console.ReadLine());

            
            if (first > second)
            {
                if (first > third)
                {
                    Console.WriteLine("Максимальное число : " + first);
                }
                else
                {
                    Console.WriteLine("Максимальное число : " + third);
                }
            }
            else
            {
                if (second > third)
                {
                    Console.WriteLine("Максимальное число : " + second);
                }
                else
                {
                    Console.WriteLine("Максимальное число : " + third);
                }
            }
        