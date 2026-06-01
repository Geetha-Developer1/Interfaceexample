using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceexample
{
    interface IPhoneBasic
    {
        void Calling();
        void Recieving();
        void SendMsg();
        void EndCall();
    }
    class IPhoneSE : IPhoneBasic
    {
       public void Calling()
        {
            Console.WriteLine("IPhoneSE is Calling");

        }
        public void Recieving()
        {
            Console.WriteLine("IPhoneSE is Recieving the Call");

        }
        public void SendMsg()
        {
            Console.WriteLine("IPhoneSE is Sending Message");

        }
        public void EndCall()
        {
            Console.WriteLine("IPhoneSE is Ending the Call");

        }

    }
    interface IPhoneAdvanced
    {
        void FaceID();
        void VideoCall();
        void AirDrop();
    }
    class Iphone16 :IPhoneSE,  IPhoneBasic, IPhoneAdvanced
    {
        public void Calling()
        {
            Console.WriteLine("IPhoneSE is Calling");

        }
        public void Recieving()
        {
            Console.WriteLine("IPhoneSE is Recieving the Call");

        }
        public void SendMsg()
        {
            Console.WriteLine("IPhoneSE is Sending Message");

        }
        public void EndCall()
        {
            Console.WriteLine("IPhoneSE is Ending the Call");

        }

        public void FaceID()
        {
            Console.WriteLine("Iphone16 Allow Faceid authentication");
        }
        public void VideoCall()
        {
            Console.WriteLine("Iphone16 is supports VideoCall");
        }
        public void AirDrop()
        {
            Console.WriteLine("Iphone16 Airdrop share files");
        }
    }
    internal class MultipleInheritance
    {
        static void Main(string[] args)
        {
            IPhoneBasic obj=new IPhoneSE();
            obj.Calling();
            obj.Recieving();
            obj.SendMsg();
            obj.EndCall();

            obj = new Iphone16();
            obj.Calling() ;
            obj.Recieving();
            obj.SendMsg();
            obj.EndCall();
            IPhoneAdvanced obj2 = new Iphone16();
            obj2.FaceID();
            obj2.VideoCall();
            obj2.AirDrop();

        }
    }
}
