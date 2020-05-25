using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game2.Model
//ТАРАНУХА ЯНА
/*
Используя Windows Forms, разработать игру «Угадай число». 
Компьютер загадывает число от 1 до 100, 
а человек пытается его угадать за минимальное число попыток. 
Компьютер говорит, больше или меньше загаданное число введенного.  
a) Для ввода данных от человека используется элемент TextBox;   
*/
{
    // if (MessageBox.Show("Are you sure?","Warning",MessageBoxButtons.YesNo)==DialogResult.Yes) this.Close();
    /*
 1. Появляется окно, где сказано, что игра началась и просят назвать число от 0 до 100. Игрок вводит число в поле.  return заданное.
 2. Если (число > заданного и step < count), появляется сообщение "Больше. Введите новое". Игрок вводит число в поле. step++.  return step.
    если (число < заданного  и step < count), появляется сообщение "Меньше. ВВедите новое". Игрок вводит число в поле. step++.  return step.
    если (число = заданному и step <= count), появляется сообщение "Верно. Игра окончена". Игрок вводит число в поле. step++.  return step.
    иначе return "Игра закончена".
     */

    class GameIgra
    {
        int current;
        int count = 0;
        int vv;
        public int Finish { get; private set; }
        public Stack<int> history = new Stack<int>();

        public int Current()
        {
           // current = Convert.ToInt32(TextBox.//Read());///???
            count++;
            return current;
        }

        public int Count
        {
            get { return count; }
        }
        public GameIgra()//
        {
            Finish = new Random().Next(0, 101);
        }

        //вывести окно с сообщением: введите число; считать это число
        //textBox1->Text = Convert::ToString(x);


        public string Vv
        {
            get
            {
                if (current == Finish)
                    return "У ТЕБЯ ПОЛУЧИЛОСЬ!!!";
                if (5 < count)
                    return "ИГРА ОКОНЧЕНА";
                else
                {
                    vv = 5 - count;
                    return "У Вас осталось : " + vv + "  попыток";
                }
            }
        }
        public GameIgra(int finish)//????
        {
            this.Finish = finish;

        }
        public GameIgra(Stack<int> history)//????
        {
            this.history = history;//????
        }
        /*
           public void Reset()
                {
                    current = 0;
                    count = 0;
                    history.Clear();
                }
                */
        /*public int Back()
        {
            if (history.Count != 0)
            {
                return history.Pop();// не работает, исключение:InvalidOperayionException
            }
            else return 0;
            */
        public override string ToString()
        {
            return current.ToString();
        }

    }
}
