using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceexample
{
    interface IPaymentGateWay
    {
        void ProcessPayment();
    }
    class PaypalGateWay:IPaymentGateWay
    {
        string un;
        string pw;
        public PaypalGateWay(string un, string pw)
        {
            this.un = un;
            this.pw = pw;
        }

        public void ProcessPayment()
        {
           if(un=="Paypal"&&pw=="Paypal123")

            Console.WriteLine("Successfully Processed Your Payment by using Paypal");
           
        }
    }
    class Credit:IPaymentGateWay
    {
        string un;
        string pw;
        public Credit(string un, string pw)
        {
            this.un = un;
            this.pw = pw;
        }

        public void ProcessPayment()
        {
            if (un == "Credit" && pw == "Credit123")

                Console.WriteLine("Successfully Processed Your Payment ");

        }
    }
    class NetBanking:IPaymentGateWay
    {
        string un;
        string pw;
        public NetBanking(string un, string pw)
        {
            this.un = un;
            this.pw = pw;
        }

        public void ProcessPayment()
        {
            if (un == "Netb" && pw == "Netb123")

                Console.WriteLine("Successfully Processed Your Payment by using NetBanking");

        }
    }
    class UPIGateWay : IPaymentGateWay
    {
        string un;
        string pw;
        public UPIGateWay(string un, string pw)
        {
            this.un = un;
            this.pw = pw;
        }

        public void ProcessPayment()
        {
            if (un == "Upigw" && pw == "Upigw123")

                Console.WriteLine("Successfully Processed Your Payment by using UPI");

        }
    }
    internal class PaymentExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select and Enter number: \n1.Paypal\n2.Credit\n3.NetBanking\n4.UPI Payments");
            int n = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Enter UserName:");
            string uname = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string pw = Console.ReadLine();
            IPaymentGateWay pm=new PaypalGateWay(uname,pw);
            if (n == 1)
            { 
                pm.ProcessPayment();
            }
            else if(n==2)
            {
                pm = new Credit(uname,pw);
                pm.ProcessPayment();
            }
            else if(n==3)
            {
                pm=new NetBanking(uname,pw);
                pm.ProcessPayment();
                
            }
            else if(n==4)
            {
                pm = new UPIGateWay(uname,pw);
                pm.ProcessPayment();
            }
        }
    }
}
