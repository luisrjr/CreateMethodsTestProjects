using System;
using System.Runtime.InteropServices;
/*
string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
bool validLength = false;
bool validZeros = false;
bool validRange = false;


foreach (string ip in ipv4Input)
{
    string[] address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);
    ValidateLength();
    ValidateZeros();
    ValidateRange();

if (validLength && validZeros && validRange)
{
    Console.WriteLine("IP Address is Valid");
} else 
{
    Console.WriteLine("IP Address is not valid");
}


void ValidateLength() {

    validLength = address.Length == 4;
}
void ValidateZeros() {

    foreach(string number in address){
        if(number.Length > 1 && number.StartsWith("0")) {
            validZeros = false;
            return;
        } 
         validZeros = true;
    }
}
void ValidateRange() {
    
    foreach (string number in address)
    {
        int addressNum;
        bool success = int.TryParse(number, out addressNum);
        if(success) {
        if(addressNum > 0 && addressNum < 256)
        {
            validRange = true;
        } else 
        {
            validRange = false;
        }
    }
    }
}
}



Random random = new Random();
int luck = random.Next(100);

string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

TellFortune();

void TellFortune() {
Console.WriteLine("A fortune teller whispers the following words:");
string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
for (int i = 0; i < 4; i++) 
{
    Console.Write($"{text[i]} {fortune[i]} ");
}
}



int[] schedule = {800, 1200, 1600, 2000};

void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
{
    int diff = 0;
    if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
    {
        Console.WriteLine("Invalid GMT");
    }
    else if(newGMT >= 0 && currentGMT >= 0 || newGMT <= 0 && currentGMT <= 0 )
    {
        diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    }
    else 
    {
        diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    }

    for (int i = 0; i < times.Length; i++)
    {
        int newTime = ((times[i] + diff) % 2400);
        Console.WriteLine($"{times[i]} -> {newTime}");
    }
}

DisplayAdjustedTimes(schedule, -3, 0);



string[] students = {"Larry", "Moe", "Curly", "Joey"};

DisplayStudentNames(students);
DisplayStudentNames(new string[] {"Mickey", "Minnie"});

void DisplayStudentNames(string[] students)
{
    foreach(string student in students)
    {
        Console.Write($"{student}, ");
    }
    Console.WriteLine();
}


double pi = 3.14159;
 PrintCircleInfo(12);


void PrintCircleArea(int radius)
{
    double area = pi * (radius * radius);
    Console.WriteLine($"Area: {area}");
}

void PrintCircleCircumference(int radius)
{
    double circumference = 2 * pi * radius;
    Console.WriteLine($"Circumference: {circumference}");
}

void PrintCircleInfo(int radius)
{
   PrintCircleArea(radius);
   PrintCircleCircumference(radius);

}


int a = 3;
int b = 4;
int c = 0;

Multiply(a, b, c);
Console.WriteLine($"outside of mehhtod: {a} * {b} = {c}");

void Multiply(int a, int b, int c)
{
    c = a * b;
    Console.WriteLine($"inside method: {c}");
}



int[] array = {1, 2, 3, 4, 5};

PrintArray(array);
Clear(array);
PrintArray(array);

void PrintArray(int[] array)
{
    foreach (int a in array)
    {
        Console.Write(a + " ");
    }
    Console.WriteLine();
}

void Clear(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = 0;
    }
}


string status = "Healthy";

Console.WriteLine($"Start: {status}");
SetHealth(false);
Console.WriteLine($"End: {status}");

void SetHealth(bool isHealthy)
{
    status = (isHealthy ? "Healthy" : "Unhealthy");
    Console.WriteLine($"Status: {status}"); 
}



string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
string[] rsvps = new string[10];
int count = 0;

RSVP("Rebecca", 1, "none", true);
RSVP("Nadia", 2, "Nuts", true);
RSVP("Linh", 2, "none", false);
RSVP("Tony", 1, "Jackfruit", true);
RSVP("Noor", 4, "none", false);
RSVP("Jonte", 2, "Stone fruit", false);
ShowRSVPs();

void RSVP(string name, int partySize, string allergies, bool inviteOnly)
{
    if(inviteOnly)
    {
        bool found = false;
        foreach (string guest in guestList)
        {
            if(guest.Equals(name))
            {
                found = true;
                break;
            } 
            if (!found) 
            {
                Console.WriteLine($"Sorry {name} is not on the guest list");
                return;
            }
        }
    }

    rsvps[count] = $"Name: {name}, \tParty Size: {partySize} , \tAllergies: {allergies}";
    count++;
}

void ShowRSVPs()
{
    Console.WriteLine("\nTotal RSVPs:");
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"{rsvps[i]}");
    }
}

*/

string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    // display internal email addresses
    string firstname = corporate[i,0].ToString();
    string lastName = corporate[i,1].ToString();
    string fullName = firstname+","+lastName; 
    DisplayEmail(fullName);
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    // display external email addresses
    string firstname = external[i,0].ToString();
    string lastName = external[i,1].ToString();
    string fullName = firstname+","+lastName; 
    DisplayEmail(fullName, externalDomain);
}

void DisplayEmail(string employeeName, string domain = "contoso.com")
{
    string[] name = employeeName.Split(',');
    string firstInitial = name[0].Substring(0,2).ToLower();
    string lastName = name[1].ToLower();
    Console.WriteLine($"{firstInitial}{lastName}@{domain}");
}