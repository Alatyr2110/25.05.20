using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Game1.Model
//ТАКАНУХА ЯНА
/*
а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
б) Добавить меню и команду «Играть». При нажатии появляется сообщение, 
какое число должен получить игрок. 
Игрок должен получить это число за минимальное количество ходов.
*/
{
    //enum StatusGame => public string Vv так получилось


    delegate void Action();
    class GameDoubler
    {
        int current;
        int count = 0;
        int steps;
        int vv;

        static public Action action;

        public int Finish { get; private set; }
        public Stack<int> history = new Stack<int>();

        public int Current
        {
            get { return current; }
        }

       public int Count
        {
         get { return count; }///???
        }

        public GameDoubler()//
        {
            Finish = new Random().Next(10, 21);
        }

        public int Steps
        {
            get
            {
                steps = 1;
                int f = Finish;
                while (f != 1)
                {
                    if (f % 2 == 0) f = f / 2;
                    else f = f - 1;
                    steps = steps + 1;
                }
                return steps; ///???
            }
        }
        
        public string Vv
        {
            get
            {
                if (current == Finish)
                    return "У ТЕБЯ ПОЛУЧИЛОСЬ!!!";
                if (steps < count)
                    return "ИГРА ОКОНЧЕНА";
                else
                {
                    vv = steps - count;
                    return "У Вас осталось : " + vv + "  попыток";
                }
            }
        }
                /*public GameDoubler(int min, int max)//
                {
                    Finish = new Random().Next(min, max+1); 
                }*/

                public GameDoubler(int finish)//????
                {
                    this.Finish = finish;
                    //current = 1;
                }

                public GameDoubler(Stack<int> history)//????
                {
                    this.history = history;//????
                }

                public int Plus()
                {
                    history.Push(current);
                    current += 1;
                    count++;

                    return current;
                }
                public int Multi()
                {
                    history.Push(current);
                    current *= 2;
                    count++;
                    return current;
                }

                public void Reset()
                {
                    current = 0;
                    count = 0;
                    history.Clear();
                }

                public int Back()
                {
                    if (history.Count != 0)
                    {
                        return history.Pop();// не работает, исключение:InvalidOperayionException
                    }
                    else return 0;

                }

        public override string ToString()
        {
            return current.ToString();
        }
    }
}