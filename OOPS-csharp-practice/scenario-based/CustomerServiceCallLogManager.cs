
using System;

class CallLog
{
    public string PhoneNumber { get; set; }
    public string Message { get; set; }
    public DateTime TimeStamp { get; set; }

    public CallLog(string phone, string message, DateTime time)
    {
        PhoneNumber = phone;
        Message = message;
        TimeStamp = time;
    }
}

class CallLogManager
{
    private CallLog[] logs;
    private int count;

    public CallLogManager(int size)
    {
        logs = new CallLog[size];
        count = 0;
    }

    public void AddCallLog(CallLog log)
    {
        if (count < logs.Length)
        {
            logs[count++] = log;
        }
    }

    public void SearchByKeyword(string keyword)
    {
        for (int i = 0; i < count; i++)
        {
            if (logs[i].Message.Contains(keyword))
            {
                Console.WriteLine(logs[i].PhoneNumber + " " + logs[i].Message);
            }
        }
    }

    public void FilterByTime(DateTime start, DateTime end)
    {
        for (int i = 0; i < count; i++)
        {
            if (logs[i].TimeStamp >= start && logs[i].TimeStamp <= end)
            {
                Console.WriteLine(logs[i].PhoneNumber + " " + logs[i].TimeStamp);
            }
        }
    }
}
