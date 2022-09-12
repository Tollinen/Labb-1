﻿//================================================
// Mat-Mats Logistik v. 1.3
//================================================

bool isRunning = true;
int nrBeställningar = 0;

while (isRunning)
{
    DisplayMenu();

    ReadInput();
}

void DisplayMenu()
{

    Console.WriteLine("======MAT-MATS LOGISTIK======\n1. Registrera ny leverans\n2. Beställ mer\n3. Ny inventering\n4. Ta bort allt\n5. Stäng");
    Console.Write(">");

}

void ReadInput()
{
    switch (Int32.Parse(Console.ReadLine()))
    {
        case 1:
            Console.WriteLine("Skönt. Då slipper vi ringa och klaga på att varorna inte levereras i tid.");
            nrBeställningar++;
            break;
        case 2:
            Console.WriteLine("Hellre mer i lager än för lite...");
            nrBeställningar++;
            break;
        case 3:
            Console.WriteLine("Vad väntar du på? Börja inventera hyllorna!");
            break;
        case 4:
            Console.WriteLine("Allt har tagits bort.");
            break;
        case 5:
            isRunning = false;
            Console.WriteLine("Bra jobbat. Ses imorgon.");
            break;
        default:
            break;
    }
}