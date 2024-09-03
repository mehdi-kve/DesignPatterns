using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Subject
    {
        private List<Observer> observers = new List<Observer>();

        public void addObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void removeObserver(Observer observer) 
        {
            observers.Remove(observer);
        }

        public void notifyObserver() 
        {
            foreach (Observer observer in observers) 
            {
                observer.update();
            }
        }
    }
}
