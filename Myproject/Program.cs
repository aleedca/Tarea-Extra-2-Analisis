class Program
{
    public void GenerateArray(){
        Random random = new Random();
        int arraySize = 10; // assign the size of the array
        for(int index = 0; index < arraySize; index++){
            int number = random.Next(1,100);
            Console.WriteLine($"Array[{index}]: {number}");
        }
    }
    
    private static void Main(string[] args){
        Program p = new Program();
        p.GenerateArray();
    }
}