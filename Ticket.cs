namespace Ticketing
{
    class Ticket
    {
        public int TicketID { get; set; }
        public string Summary { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string Submitter { get; set; }
        public string Assigned { get; set; }
        public List<string> Watching { get; set; }

        public Ticket(int ticketID, string summary, string status, string priority, string submitter, string assigned, List<string> watching)
        {
            TicketID = ticketID;
            Summary = summary;
            Status = status;
            Priority = priority;
            Submitter = submitter;
            Assigned = assigned;
            Watching = watching;
        }
    }
}