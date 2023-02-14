public class Number : ISquare, IIsGood
{
    private int number;

    public Number(int number)
    {
        this.number = number;
    }

    public bool IsGood(int n) => n == this.Square();

    public int Square() => number*number;
}    