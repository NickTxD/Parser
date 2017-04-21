using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using AngleSharp.Parser.Html;
using Parser.BLL.Contracts;
using Parser.DAL;
using Parser.Domain;

namespace Parser.BLL.Implementations
{
    public class LiquidBLL : ILiquidBLL
    {
        private readonly IRepository _repository;

        public LiquidBLL(IRepository repository)
        {
            this._repository = repository;
            var thr = new Thread(ThreadSaveAll);
            thr.Start();
        }
        public Liquid CreateNew(int article, bool amountIndicated, bool strengthIndicated, string link, string name, bool availability, int price, List<double> strength, List<int> amount)
        {
            var result = new Liquid(article, amountIndicated, strengthIndicated, link, name, availability, price, strength, amount);

            return this._repository.Save(result);
        }

        public void ThreadSaveAll()
        {
            for (;;)
            {
                Thread.Sleep(100*10);
                SaveAll();
            }
        }
        public ICollection<Liquid> SaveAll()
        {
            var grabber = new Grabber();

            var liqs = grabber.Get();
            
            foreach (var variable in liqs)
            {
                this._repository.Save(variable);
            }
            return liqs;
        }
        public ICollection<Liquid> GetAll()
        {
            return this._repository.GetAllLiquids();
        }
        public Liquid GetById(Guid id)
        {
            return this._repository.GetLiquidByGuid(id);
        }
    }
}
