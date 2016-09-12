using System;

namespace PackageEntities
{
    public class Package
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public int DestinationId { get; set; }
        public DateTime DispatchedTime { get; set; }
        public DateTime RecievedTime { get; set; }
        public int DispatcherId { get; set; }
        public int RecieverId { get; set; }
        public string Sender { get; set; }
        public String Reciever { get; set; }
        public string SenderNumber { get; set; }
        public string RecieverNumber { get; set; }
        public string Status { get; set; }

        public Package()
        {
            
        }

        public Package(int id, string description, string code, int destinationId, DateTime dispatchedTime, DateTime recievedTime, int dispatcherId, int recieverId, string sender, string reciever, string senderNumber, string recieverNumber, string status)
        {
            Id = id;
            Description = description;
            Code = code;
            DestinationId = destinationId;
            DispatchedTime = dispatchedTime;
            RecievedTime = recievedTime;
            DispatcherId = dispatcherId;
            RecieverId = recieverId;
            Sender = sender;
            Reciever = reciever;
            SenderNumber = senderNumber;
            RecieverNumber = recieverNumber;
            Status = status;
        }

    }
}