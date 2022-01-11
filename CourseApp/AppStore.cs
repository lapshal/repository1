

namespace Exam
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks; 





    public class AppStore
    {
        private List<Iapp> apps = new List<Iapp>();



        public AppStore(string name)
        {
            this.Name = name;
        }


        public string Name { get; set; }




        public void Apps(string name, decimal price, string os)
        {
            apps.Add(new App(name, price, os));
        }



        public void Present()
        {
            foreach(IApp item in apps)
            {
                item.Present();
            }
        }




 

    }
}
