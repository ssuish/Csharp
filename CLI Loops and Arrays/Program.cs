static void linebreak() {
    Console.WriteLine("\n");
}

// Different types of Loops

Console.WriteLine("For Loops");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Powers of 2: ");
int fornum = 1;
for (int a = 1; a < 10; a++){
    fornum += fornum;
    Console.Write("{0} ", fornum);
}
Console.ResetColor();

linebreak();

Console.WriteLine("While Loops");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Powers of 2: ");
int b = 1;
int whilenum = 1;
while (b < 10)
{
    whilenum += whilenum;
    b++;
    Console.Write("{0} ", whilenum);
}
Console.ResetColor();

linebreak();

Console.WriteLine("Do... While Loops");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Powers of 2: ");
int c = 1;
int donum = 1;
do {
    donum += donum;
    c++;
    Console.Write("{0} ", donum);
}
while (c < 10);
Console.ResetColor();

linebreak();

// initialization
string[] tevyat = {"Mondstadt", "Liyue", "Inuzuma", "Sumeru", "Fontaine"};

Console.ResetColor();

Console.WriteLine("Foreach Loops");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Tevyat locations: ");
foreach (string loc in tevyat){
    Console.Write("{0} ", loc);
}
Console.ResetColor();

linebreak();

// initialization
string[,] notable_locations = new string[2,2] {{"Dragonspine", "Starfell"}, {"Chasm", "Harbor"}};

Console.WriteLine("Nested Loops");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Notable Locations: ");
for (int row = 0; row < 2; row++)
{
    for (int col = 0; col < 2; col++)
    {
        Console.Write("{0} ", notable_locations[row, col]);
    }
}
Console.ResetColor();

linebreak();

// Different types of Arrays

// Accessing array
tevyat[0] = "Winery";
tevyat[1] = "Enkanomiya";
tevyat[2] = "Chasm";
tevyat[3] = "Khaenriah";
tevyat[4] = "Natlan";

Console.WriteLine("Single Dimensional Array");
Console.WriteLine("Tevyat locations: ");
Console.ForegroundColor = ConsoleColor.Green;
foreach (string loc in tevyat){
    Console.Write("{0} ", loc);
}
Console.ResetColor();

linebreak();

// Accessing multidimensional array (2D)
notable_locations[0,1] = "Starfell";
notable_locations[1,0] = "Guili";

Console.WriteLine("Two Dimensional Array");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Notable Locations: ");
for (int row = 0; row < 2; row++)
{
    for (int col = 0; col < 2; col++)
    {
        Console.Write("{0} ", notable_locations[row, col]);
    }
}
Console.ResetColor();

linebreak();

// Multidimensional Array (3D)
string[,,] covidData = new string[3,2,4];
Random rad = new Random();

covidData[0,1,0] = "Tokyo City";
covidData[1,1,0] = "New York";
covidData[2,1,0] = "London City";

for (int i = 0; i < covidData.GetLength(0); i++){
    for (int j = 0; j < covidData.GetLength(1); j++){
        for (int k = 0; k < covidData.GetLength(2); k++){
            covidData[i,0,0] = "Location ";
            covidData[i,0,1] = "Active Cases ";
            covidData[i,0,2] = "Recoveries ";
            covidData[i,0,3] = "Deaths ";
            if (covidData[i,j,k] == null){
                covidData[i,j,k] = rad.Next(0, 1000).ToString() + "\t ";
            }
        }
    } 
}

Console.WriteLine("Multidimensional Array (3D)");
Console.ForegroundColor = ConsoleColor.Green;
for (int i = 0; i < covidData.GetLength(0); i++){
    for (int j = 0; j < covidData.GetLength(1); j++){
        for (int k = 0; k < covidData.GetLength(2); k++){
            Console.Write(covidData[i,j,k] + "\t ");
        }
        Console.Write("\n");
    }
}
Console.ResetColor();