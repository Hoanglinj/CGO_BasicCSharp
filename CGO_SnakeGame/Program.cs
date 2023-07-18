using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CGO_SnakeGame
{
    internal class Program
    {
       
        
            // Parameter
            public Random rand = new Random();
            public ConsoleKeyInfo keypress = new ConsoleKeyInfo();
            int score, headX, headY, fruitX, fruitY, nTail;
            int[] TailX = new int[100];
            int[] TailY = new int[100];
            const int height = 20;
            const int width = 60;
            const int panel = 10;
            bool gameOver, reset, isprinted, horizontal, vertical;
            string dir, pre_dir;

            int high_score = 0; 
            int typefruit = 1; 
            List<string> symbolfruit = new List<string>() { "?", "@", "$", "*", "~" }; 
                                                                                       
            void ShowBanner()
            {
                Console.SetWindowSize(width, height + panel); 
                Console.ForegroundColor = ConsoleColor.Green;
                Console.CursorVisible = false;  
                Console.WriteLine("===SNAKE GAME===");
                Console.WriteLine("Huong dan choi game: ");
                Console.WriteLine("- Nhan phim bat ky de choi");
                Console.WriteLine("- Nhan phim P de tam dung choi");
                Console.WriteLine("- Nhan phim R de choi lai van moi");
                Console.WriteLine("- Nhan phim Q de ngung choi");
               
                keypress = Console.ReadKey();    
                if (keypress.Key == ConsoleKey.Q) Environment.Exit(0);
            }
            
            void Setup()
            {
                dir = "RIGHT"; pre_dir = ""; 
                score = 0; nTail = 0;
                gameOver = reset = isprinted = false;
                headX = 30; 
                headY = 10; 
                randomQua();
            }

            void randomQua()
            {
                if (score < 5) typefruit = 1;
                else typefruit = rand.Next(1, 5);

                fruitX = rand.Next(1, width - 1); 
                fruitY = rand.Next(1, height - 1);
            }
            
            void Update()
            {
                while (!gameOver)
                {
                    CheckInput(); 
                    Logic();      
                    Render();     

                    if (reset) break;
                    Thread.Sleep(getDelay());   
                }
                if (gameOver) Lose();
            }
            
            int getDelay()
            {
                if (score < 10) return 200;
                if (score < 20) return 100;
                if (score < 50) return 30;
                return 5;
            }

            
            void CheckInput()
            {
                while (Console.KeyAvailable)
                {
                    keypress = Console.ReadKey();
                    pre_dir = dir;
                    switch (keypress.Key)
                    {
                        case ConsoleKey.LeftArrow: dir = "LEFT"; break;
                        case ConsoleKey.RightArrow: dir = "RIGHT"; break;
                        case ConsoleKey.DownArrow: dir = "DOWN"; break;
                        case ConsoleKey.UpArrow: dir = "UP"; break;

                        case ConsoleKey.P: dir = "STOP"; break;   
                        case ConsoleKey.Q: Environment.Exit(0); break;
                    }
                }
            }
           
            void Logic()
            {
                int preX = TailX[0], preY = TailY[0]; 
                int tempX, tempY;
          
                if (dir != "STOP")
                {
                    TailX[0] = headX; TailY[0] = headY;

                    for (int i = 1; i < nTail; i++)
                    {
                        tempX = TailX[i]; tempY = TailY[i];
                        TailX[i] = preX; TailY[i] = preY;
                        preX = tempX; preY = tempY;
                    }
                }
                switch (dir)
                {
                    case "LEFT": headX--; break;
                    case "RIGHT": headX++; break;
                    case "UP": headY--; break;
                    case "DOWN": headY++; break;
                    case "STOP":
                        {
                            while (true)
                            {
                                Console.Clear(); 
                                Console.WriteLine("===SNAKE GAME===");
                                Console.WriteLine("Dang tam dung choi game!");
                                Console.WriteLine("- Nhan phim P de tiep tuc choi");
                                Console.WriteLine("- Nhan phim R de choi lai van moi");
                                Console.WriteLine("- Nhan phim Q de ngung choi");

                                keypress = Console.ReadKey();
                                if (keypress.Key == ConsoleKey.Q) Environment.Exit(0);
                                if (keypress.Key == ConsoleKey.R)
                                {
                                    reset = true; break;
                                }
                                if (keypress.Key == ConsoleKey.P) 
                                    break;
                            }
                        }
                        dir = pre_dir; break;
                }
               
                if (headX <= 0 || headX >= width - 1 || headY <= 0 || headY >= height - 1)
                    gameOver = true;
                else gameOver = false;
               
                if (headX == fruitX && headY == fruitY) 
                {
                    score += 3 * typefruit; 
                    nTail++;      
                    randomQua();
                }
               
             
                if (((dir == "LEFT" && pre_dir != "UP") && (dir == "LEFT" && pre_dir != "DOWN")) || ((dir == "RIGHT" && pre_dir != "UP") && (dir == "RIGHT" && pre_dir != "DOWN")))
                    horizontal = true; 
                else horizontal = false;
                
                if (((dir == "UP" && pre_dir != "LEFT") && (dir == "UP" && pre_dir != "RIGHT")) || ((dir == "DOWN" && pre_dir != "LEFT") && (dir == "DOWN" && pre_dir != "RIGHT")))
                    vertical = true; 
                else vertical = false;

                
                for (int i = 1; i < nTail; i++)
                {
                    if (headX == TailX[i] && headY == TailY[i])
                    {
                        
                        if (horizontal || vertical) gameOver = false;
                        else gameOver = true;
                    }
                    if (fruitX == TailX[i] && fruitY == TailY[i]) 
                        randomQua();
                }
            }
         
            void Render()
            {
                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (i == 0 || i == height - 1) 
                            Console.Write("#");
                        else if (j == 0 || j == width - 1) 
                            Console.Write("#");
                        else if (fruitX == j && fruitY == i) 
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(symbolfruit[typefruit - 1]);
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else if (headX == j && headY == i) 
                            Console.Write("()");
                        else
                        {   //than con ran
                            isprinted = false;
                            for (int k = 0; k < nTail; k++)
                            {
                                if (TailX[k] == j && TailY[k] == i)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("[]"); 
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    isprinted = true;
                                }
                            }
                            if (!isprinted) Console.Write(" "); 
                        }
                    }
                    Console.WriteLine(); 
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Diem cua ban: {0} | Diem cao nhat: {1}", score, high_score);
            }
            
            void Lose()
            {
                if (high_score < score) high_score = score; 
                Console.WriteLine("===SNAKE GAME===");
                Console.WriteLine("Ban da thua!");
                Console.WriteLine("- Nhan phim R de choi lai van moi");
                Console.WriteLine("- Nhan phim Q de ngung choi");

                while (true)
                {
                    keypress = Console.ReadKey();
                    if (keypress.Key == ConsoleKey.Q) Environment.Exit(0);
                    if (keypress.Key == ConsoleKey.R)
                    {
                        reset = true; break;
                    }
                }
            }
            static void Main(string[] args)
            {
                Program snakegame = new Program();
                snakegame.ShowBanner(); 
                while (true)
                {
                    snakegame.Setup();
                    snakegame.Update();
                    Console.Clear();
                }
            
            }
    }
}

