int Quater(int xC, int yC){
    if (xC>0 && yC>0) return 1;
    if (xC<0 && yC>0) return 2;
    if (xC<0 && yC<0) return 3;
    if (xC>0 && yC<0) return 4;
    return 0;
}

Console.WriteLine("Input the coordinates");
Console.Write("X");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y");
int y = Convert.ToInt32(Console.ReadLine());

int quater = Quater(x,y);
string result = quater>0 
                ? $"The dot is in {quater}th quater" 
                : "Choose differend numbers";

Console.WriteLine(result);

