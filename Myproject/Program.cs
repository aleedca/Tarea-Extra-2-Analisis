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
            array[index] = number; // add random number to array
        }
    }

    public int GreatestNumber(){
        int greatestNumber = 0;

        for(int index = 0; index < arraySize; index++){
            int next = index + 1;

            if(next < arraySize){
                if(array[index] >= array[next]){
                    greatestNumber = array[index];
                }
                else{
                    greatestNumber = array[next];
                }
            }
        }
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
        Console.Write(p.GreatestNumber());
    }
}