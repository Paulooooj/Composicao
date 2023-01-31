﻿using Composicao.Entities.Enums;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Composicao.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status{ get; set; }
        public Client Client { get; set; }
        public List<OrdemItem> Items { get; set; } = new List<OrdemItem>();

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            this.Moment = moment;
            this.Status = status;
            this.Client = client;
        }
       
        public void AddItem(OrdemItem item) {
            Items.Add(item);
        }

        public void RemoveItem(OrdemItem item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            double sum = 0.0;
            foreach(OrdemItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order Status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items: ");
            
            foreach(OrdemItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2",CultureInfo.InvariantCulture));
            return sb.ToString();
        }

    }

    }

