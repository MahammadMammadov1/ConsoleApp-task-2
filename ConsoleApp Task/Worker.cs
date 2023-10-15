using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Task
{
    public class Worker
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        private string _workerCode;
        private double _experience;


        public Worker(string name,string surName, double experience)
        {
            this.Name = name;
            this.SurName = surName;
            this._experience = experience;
        }

        public string WorkerCode
        {
            get 
            { 
                return _workerCode; 
            }
            set
            {
                for (int i = 0; i <value.Length; i++)
                {
                    if (value[i] == ' ' && value[i + 1] != ' ')
                    {
                        _workerCode = value[0].ToString().ToUpper() + value[i+1].ToString().ToUpper();
                    }
                    
                }
            }
        }
        

        public double Experience
        {
            get 
            {
                return _experience; 
            }
            set
            {
                if (value>0 && value < 70) 
                { 
                    _experience = value;
                }
            }
        }


    }
}
