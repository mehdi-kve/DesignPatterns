﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class DataSource : Subject
    {
        private int value; 

        public int getValue()
        {
            return value;
        }

        public void setValue(int value)
        {
            this.value = value;
            notifyObserver();
        }
    }
}
