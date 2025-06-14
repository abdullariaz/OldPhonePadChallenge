using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Test Case 1: " + OldPhone.OldPhonePad("33#"));                 // E
        Console.WriteLine("Test Case 2: " + OldPhone.OldPhonePad("227*#"));               // B
        Console.WriteLine("Test Case 3: " + OldPhone.OldPhonePad("4433555 555666#"));     // HELLO
        Console.WriteLine("Test Case 4: " + OldPhone.OldPhonePad("8 88777444666*664#"));  // TEST
        Console.WriteLine("Test Case 5: " + OldPhone.OldPhonePad("222 2 22#"));           // CAB
        Console.WriteLine("Test Case 6: " + OldPhone.OldPhonePad("7777 777#"));           // SS
    }
}
