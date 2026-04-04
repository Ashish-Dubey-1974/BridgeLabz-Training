
interface IPayable
{
    double CalculateBill();
}

abstract class Patient
{
    private int patientId;
    private string name;

    public int PatientId
    {
        get { return patientId; }
    }

    public string Name
    {
        get { return name; }
    }

    protected Patient(int id, string name)
    {
        patientId = id;
        this.name = name;
    }

    public abstract void DisplayInfo();
}

class InPatient : Patient, IPayable
{
    private int daysAdmitted;
    private double dailyCharge;

    public InPatient(int id, string name, int days, double charge)
        : base(id, name)
    {
        daysAdmitted = days;
        dailyCharge = charge;
    }

    public double CalculateBill()
    {
        return daysAdmitted * dailyCharge;
    }

    public override void DisplayInfo()
    {
        System.Console.WriteLine("InPatient: " + Name + " | Bill: " + CalculateBill());
    }
}

class OutPatient : Patient, IPayable
{
    private double consultationFee;

    public OutPatient(int id, string name, double fee)
        : base(id, name)
    {
        consultationFee = fee;
    }

    public double CalculateBill()
    {
        return consultationFee;
    }

    public override void DisplayInfo()
    {
        System.Console.WriteLine("OutPatient: " + Name + " | Bill: " + CalculateBill());
    }
}

class Doctor
{
    public string DoctorName { get; set; }

    public Doctor(string name)
    {
        DoctorName = name;
    }
}

class Bill
{
    public static void GenerateBill(IPayable payable)
    {
        System.Console.WriteLine("Total Bill Amount: " + payable.CalculateBill());
    }
}
