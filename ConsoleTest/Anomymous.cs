using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    public class Anomymous
    {
        private int number = 0;

        public void CallAnomymous(int num)
        {
            number = 100;

            HandleAnomymous(() =>
            {
                int n = num;
            });
        }

        public void HandleAnomymous(Action action)
        {
            number = 500;

            action();
        }


    }
}
