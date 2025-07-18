using System;

//public class Medication
//{
//    private string name;
//    private int id;
//    private string symptoms;
//    private int age;



//    public Medication(int id,string Symp,int age,string name)
//    {
//        this.name = name;
//        this.id = id;
//        this.symptoms = Symp;
//        this.age = age;
//    }


//    public void Medicine()
//    {
//        if (symptoms == "fever")
//        {
//            if (age < 18)
//            {
//                System.Console.WriteLine("1 mg dolo");
//            }
//            else if (age >= 18)
//            {
//                System.Console.WriteLine("1 mg Paracetamol");
//            }

//        }

//        else if (symptoms == "Chicken Pox")
//        {
//            if (age < 18)
//            {
//                System.Console.WriteLine("2mg Rectanol");


//              else if (age >= 18)
//                {
//                    System.Console.WriteLine("8mg Rectanol");
//                }
//            }
//        }


//    }
//}



public class Medicalbot
{
    private const string botname = "bob";

    public static string getbotname()
    {
        return botname;
    }

    public void prescribemedication(Patient patient)
    {
        string prescription = "";

        string symptom = patient.getsymptom();

        if (symptom == "headache")
        {
            prescription = getdosage("ibuprofen", patient);
        }
        else if (symptom == "skin rashes")
        {
            prescription = getdosage("diphenhydramine", patient);
        }
        else if (symptom == "dizziness")
        {
            if (patient.gethistory()=="diabetes")
            {
                prescription = getdosage("metformin", patient);
            }
            else
            {
                prescription = getdosage("dimenhydrinate", patient);
            }
        }
        else
        {
            prescription = "no prescription available for the symptom.";
        }

        Console.WriteLine("\nyour prescription based on your age, symptoms and medical history:");
        Console.WriteLine(prescription);
        patient.setprescription(prescription);
    }
    private string getdosage(string medicinename, Patient patient)
    {
        int age = patient.getage();


        if (medicinename == "ibuprofen") {
            if (age < 18) return "ibuprofen 400 mg";
            else return "ibuprofen 800 mg";
        }

        else if (medicinename=="diphenhydramine") {
            if (age < 18) return "diphenhydramine 50 mg";
            else return "diphenhydramine 300 mg";
        }

        else if (medicinename == "dimenhydrinate") {
            if (age < 18) return "dimenhydrinate 50 mg";
            else return "dimenhydrinate 400 mg";
        }

        else if (medicinename == "metformin") {
            return "metformin 500 mg";
        }
        return "none";
    }
}
public class Patient
{
    private string name;
    private int age;
    private string gender;
    private string history;
    private string symptomcode;
    private string prescription;

    public bool setname(string name, out string error)
    {
        if (name.Length < 2)
        {
            error = "invalid";
            return false;
        }
        this.name = name;
        error = "";
        return true;
    }

    public string getname()
    {
        return name;
    }

    public bool setage(int age, out string error)
    {
        if (age < 0 || age > 100)
        {
            error = "invalid";
            return false;
        }
        this.age = age;
        error = "";
        return true;
    }

    public int getage()
    {
        return age;
    }

    public bool setgender(string gender, out string error)
    {
        gender = gender.ToLower();
        if (gender == "male" || gender == "female" || gender == "other")
        {
            this.gender = gender;
            error = "";
            return true;
        }
        else
        {
            error = "invalid";
            return false;
        }
    }

    public string getgender()
    {
        return gender;
    }

    public void sethistory(string history)
    {
        this.history = history;
    }

    public string gethistory()
    {
        return history;
    }

    public bool setsymptomcode(string symptomcode, out string error)
    {
        symptomcode = symptomcode.ToLower();
        if (symptomcode == "s1" || symptomcode == "s2" || symptomcode == "s3")
        {
            this.symptomcode = symptomcode;
            error = "";
            return true;
        }
        else
        {
            error = "invalid";
            return false;
        }
    }

    public string getsymptom()
    {
        if (symptomcode == "s1")
        {
            return "headache";
        }
        else if(symptomcode == "s2")
        {
            return "skin rashes";
        }
        else
        {
            return "dizziness";
        }
        
    }

    public void setprescription(string prescription)
    {
        this.prescription = prescription;
    }

    public string getprescription()
    {
        return prescription;
    }
}



class MedicalAp
{
   public static void Main()
    {
        Patient p = new Patient();
        Medicalbot bot = new Medicalbot();

        Console.WriteLine("enter your patient details:");

        string err;

        Console.WriteLine("enter patient name: ");
       string h = Console.ReadLine();
        if (!p.setname(h, out err))
        {
           Console.WriteLine(err);
    
        }

       Console.WriteLine("enter patient age: ");
        bool c = int.TryParse(Console.ReadLine(),out int age);
        if ( !c || !p.setage(age, out err))
        {
            Console.WriteLine("invalid age");
           
        }

        Console.WriteLine("enter patient gender: ");
        string g = Console.ReadLine();
        if (!p.setgender(g, out err))
        {
            Console.WriteLine(err);
           
        }

        Console.WriteLine("enter medical history");
        p.sethistory(Console.ReadLine());

        Console.WriteLine($"\nwelcome, {p.getname()}, {p.getage()}.");

        Console.WriteLine("\nwhich of the following symptoms do you have:");
        Console.WriteLine("s1. headache");
        Console.WriteLine("s2. skin rashes");
        Console.WriteLine("s3. dizziness");
        Console.WriteLine("enter the symptom code from above list :s1, s2 or s3 ");
        string code = Console.ReadLine();
        if (!p.setsymptomcode(code, out err))
        {
            Console.WriteLine(err);
           
        }

        bot.prescribemedication(p);

        Console.WriteLine("Thankyou");
    }
}