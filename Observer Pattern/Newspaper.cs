using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer_Pattern
{
    interface INewsPaperHub
    {
        void AddSuscribers(ISuscribers suscriber);
        void RemoveSuscribers(ISuscribers suscriber);
        void NotifySuscribers(); 
    }
    interface ISuscribers
    {
        void update(string title, string body, int refNo);
    }

    class Newspaper : INewsPaperHub
    {
        public int RefNo { get; set; }
        public string  Title { get; set; }
        public string Body { get; set; }
        //public Newspaper(string title, string body, int refNo)
        //{
        //    RefNo = refNo;
        //    Title = title;
        //    Body = body;
        //    NotifySuscribers();
        //}
        public List<ISuscribers> suscribersList = new List<ISuscribers>();
        public void AddSuscribers(ISuscribers suscriber)
        {
            suscribersList.Add(suscriber); 

        }
        public void RemoveSuscribers(ISuscribers suscriber)
        {
            if (suscribersList.Count < 1) return;
            suscribersList.Remove(suscriber);
        }
        public void UpdateSuscribers(string title, string body, int refNo)
        {
            RefNo = refNo;
            Title = title;
            Body = body;
            NotifySuscribers();
        }
        public void  ClearAllSuscribers()
        {
            if (suscribersList.Count < 1) return;
            suscribersList.Clear();
        }
        public void NotifySuscribers()
        {
            foreach(ISuscribers suscribers in suscribersList)
            {
                suscribers.update(Title,Body,RefNo);
            }
        }
    }
    //Later We will create a suscriber Clss that they must all inherit

   public class Suscribers : ISuscribers
    {
        private Newspaper newspaper;
         Suscribers(Newspaper newspaper)
        {
            this.newspaper = newspaper;
            newspaper.AddSuscribers(this);
        }
        public int RefNo { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public void update(string title, string body, int refNo)
        {
            RefNo = refNo;
            Title = title;
            Body = body;
            display();

        }

        public void display()
        {
            Console.WriteLine($"{Title} \n {Body} \n {RefNo} ");
        }

    }
    class KolawoleSuscriber : ISuscribers
    {
        public int RefNo { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public void update(string title, string body, int refNo)
        {
            RefNo = refNo;
            Title = title;
            Body = body;
            display();

        } 

        public void display()
        {
            Console.WriteLine($"{Title} \n {Body} \n {RefNo} ");
        }
    }

    class DupeSuscriber :ISuscribers
    {
      
        public int RefNo { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public void update(string title, string body, int refNo)
        {
            RefNo = refNo;
            Title = title;
            Body = body;
            display();

        }

        public void display()
        {
            Console.WriteLine($"{Title} \n {Body} \n {RefNo} ");
        }
    }
}
