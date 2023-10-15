using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Task
{
    public class Department
    {
        public string Name { get; set; }
        Worker[] workers = Array.Empty<Worker>();

        public void AddWorker(Worker worker)
        {
            Array.Resize(ref workers, workers.Length+ 1);
            workers[^1] = worker;
            
        }

        public void SearchWorker(string name)
        { 
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].Name.ToUpper() == name.ToUpper()) 
                {
                    Console.WriteLine($"Worker name : {workers[i].Name} \n Worker surname : {workers[i].SurName} \n Worker experience : {workers[i].Experience}");
                }
            }
        }

        public void SearchWorker(byte minExperience , byte maxExperience) 
        { 
            for(int i = 0;i < workers.Length;i++)
            {
                if(minExperience < workers[i].Experience && maxExperience > workers[i].Experience)
                {
                    Console.WriteLine($"Worker name : {workers[i].Name} - Worker surname : {workers[i].SurName} - Worker experience : {workers[i].Experience}");
                }
            }
        }

        public void ShowAllWorkers()
        {
            for (int i = 0; i < workers.Length; i++)
            {
                Console.WriteLine($"Worker name : {workers[i].Name} - Worker surname : {workers[i].SurName} - Worker experience : {workers[i].Experience}");
            }
        }


        
    }
}
