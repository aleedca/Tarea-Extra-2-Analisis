class Program
{
    public void GenerateArray(int arraySize){
        Random random = new Random();
        int[] array = new int[arraySize+1];

        for(int index = 0; index < arraySize; index++){
            int number = random.Next(1,100);
            array[index] = number; // add random number to the array
            // Console.WriteLine($"Array[{index}]: {number}");
        }
    }

    public void GreatestNumber(){

    }
    
    private static void Main(string[] args){
        Program p = new Program();
        p.GenerateArray(10);
    }
}