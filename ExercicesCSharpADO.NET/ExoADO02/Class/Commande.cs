using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoADO02.Class
{
    internal class Commande
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
        public DateTime Date { get; set; }
        public Client? Client { get; set; }

        public Commande(int id, decimal total, DateTime date)
        {
            Id = id;
            Total = total;
            Date = date;
        }

        public Commande(decimal total, DateTime date)
        {
            Total = total;
            Date = date;
        }

        public override string ToString()
        {
            return $"ID Commande: {Id}, Date: {Date}, Total: {Total}, Client: {(Client is null ? "aucun" : Client.Prenom + " " + Client.Nom.ToUpper() )}";
        }
    }
}