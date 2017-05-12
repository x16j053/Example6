using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example6
{
    class Program
    {
        static void Main(string[] args)
        {
            //変数の宣言、初期化
            int score = (int)0.5;             //int型（整数型）
            double pai = 3.1415;        //double（実数型）
            string name = "TARO";       //string型（文字列型）

            //変数に格納された値を画面に表示
            Console.WriteLine("SCORE = {0}", score);
            Console.WriteLine("AVE = {0}", pai);
            Console.WriteLine("NAME = {0}", name);
        }
    }
}
