class Program
{
    int arraySize;
    int[] array;
    Random random;
    int counter;

    public Program(){
        arraySize = 10;
        counter = 0;
        array = new int[arraySize+1];
        random = new Random();
    }

    public void GenerateArray(){
        for(int index = 0; index < arraySize; index++){
            int number = random.Next(1,10);
            array[index] = number; // add random number to array
        }
    }

    public int GreatestNumber(){
        int greatestNumber = array[0];
        counter++;
        counter += (2*arraySize) + 2;
        for(int index = 0; index < arraySize; index++){
            int next = index + 1;
            counter++;
            counter += 2;
            if((next < arraySize) && (greatestNumber < array[next])){
                greatestNumber = array[next];
                counter++;
            }
        }
        counter ++;
        return greatestNumber;
    }

    public void PrintArray(){
        Console.Write("Array: [");
        for(int index = 0; index < arraySize; index++){
            Console.Write(array[index]);
            if(index < arraySize-1) Console.Write(",");
        }
        Console.WriteLine("]");
    }
    
    private static void Main(string[] args){
        Program p = new Program();
        p.GenerateArray();
        p.PrintArray();
        Console.WriteLine(p.GreatestNumber());
        Console.WriteLine($"Time complexity: {p.counter}");
    }
}