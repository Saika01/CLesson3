string Quater(int number){
    if (number == 1) return "x>0 && y>0";
    if (number == 2) return "x<0 && y>0";
    if (number == 3) return "x<0 && y<0";
    if (number == 4) return "x>0 && y<0";
    return "Choose differend number";
}

Console.WriteLine("Input the quater");
int x = Convert.ToInt32(Console.ReadLine());

string quater = Quater(x);
string result = x>0 && x<5 
                ? $"The dots can be in {quater}" 
                : "Choose differend number";

Console.WriteLine(result);
