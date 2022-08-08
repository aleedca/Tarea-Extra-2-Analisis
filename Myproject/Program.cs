class Program
{
    int arraySize;
    int[] array;
    Random random;

    public Program(){
        arraySize = 10;
        array = new int[arraySize+1];
        random = new Random();
    }

    public void GenerateArray(){
        for(int index = 0; index < arraySize; index++){
            int number = random.Next(1,100);
            array[index] = number; // add random number to the array
        }
    }

    public void GreatestNumber(){

    }

    public void PrintArray(){
        for(int index = 0; index < arraySize; index++){
            Console.WriteLine($"Array[{index}]: {array[index]}");
        }
    }
    
    private static void Main(string[] args){
        Program p = new Program();
        p.GenerateArray();
        p.printArray();
    }
}